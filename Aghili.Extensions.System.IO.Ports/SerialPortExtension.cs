
using System.IO.Ports;
using System.Text;

namespace Aghili.Extensions.System.IO.Ports
{
    public static class SerialPortExtension
    {
        public static ValueTask<int> ReadAsync(this SerialPort serialPort,byte[] buffer,CancellationToken cancellationToken)
        {
            int lenght = serialPort.BytesToRead;
            if (lenght == 0)
                return ValueTask.FromResult(0);
            return serialPort.BaseStream.ReadAsync(buffer,cancellationToken);
        }
        public static async ValueTask<string> ReadExistingAsync(this SerialPort serialPort, CancellationToken cancellationToken)
        {
            int lenght = serialPort.BytesToRead;
            if (lenght == 0)
                return string.Empty;
            byte[] buffer = new byte[lenght];
            await serialPort.BaseStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            return serialPort.Encoding.GetString(buffer);
        }

        public static async ValueTask<byte> ReadByteAsync(this SerialPort serialPort, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (serialPort.BytesToRead > 0)
                    break;
                await Task.Delay(100, cancellationToken).ConfigureAwait(true);
            }
            
            cancellationToken.ThrowIfCancellationRequested();

            byte[] buffer = new byte[1];
            await serialPort.BaseStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            return buffer[0];
        }
        public static async ValueTask<char> ReadCharAsync(this SerialPort serialPort, CancellationToken cancellationToken)
        {
            int byte_count = serialPort.Encoding.GetMaxByteCount(1);

            while (!cancellationToken.IsCancellationRequested)
            {
                if (serialPort.BytesToRead >= byte_count)
                    break;
                await Task.Delay(100, cancellationToken).ConfigureAwait(true);
            }

            cancellationToken.ThrowIfCancellationRequested();

            byte[] buffer = new byte[byte_count];
            await serialPort.BaseStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            return serialPort.Encoding.GetChars(buffer)[0];
        }
        public static async ValueTask<string> ReadLineAsync(this SerialPort serialPort, CancellationToken cancellationToken)
        {
            int byte_count = serialPort.Encoding.GetMaxByteCount(1);

            byte[] buffer = new byte[byte_count];

            string result = "";
            while (!cancellationToken.IsCancellationRequested)
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    if (serialPort.BytesToRead >= byte_count)
                        break;
                    await Task.Delay(100, cancellationToken).ConfigureAwait(true);
                }
                await serialPort.BaseStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
                char extracted_char = serialPort.Encoding.GetChars(buffer)[0];
                if (extracted_char.Equals(Environment.NewLine))
                    break;
                else
                    result += extracted_char;
            }

            return result;
        }
        public static async ValueTask<string> ReadTo(this SerialPort serialPort, string value, CancellationToken cancellationToken)
        {
            int byte_count = serialPort.Encoding.GetMaxByteCount(1);

            byte[] buffer = new byte[byte_count];

            string result = "";
            while (!cancellationToken.IsCancellationRequested)
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    if (serialPort.BytesToRead >= byte_count)
                        break;
                    await Task.Delay(100, cancellationToken).ConfigureAwait(true);
                }
                await serialPort.BaseStream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
                char extracted_char = serialPort.Encoding.GetChars(buffer)[0];
                result += extracted_char;
                if (result.EndsWith(value, StringComparison.InvariantCultureIgnoreCase))
                    break;
            }
            result = result.Remove(result.Length - value.Length);
            return result;
        }

        public static ValueTask<int> ReadAsync(this SerialPort serialPort, Memory<byte> buffer, CancellationToken cancellationToken)
        {
            int lenght = buffer.Length;
            if (lenght == 0)
                return ValueTask.FromResult(0);
            return serialPort.BaseStream.ReadAsync(buffer, cancellationToken);
        }
        public static Task<int> ReadAsync(this SerialPort serialPort, byte[] buffer,int offset,int count, CancellationToken cancellationToken)
        {
            return serialPort.BaseStream.ReadAsync(buffer,offset,count, cancellationToken);
        }
    }
}
