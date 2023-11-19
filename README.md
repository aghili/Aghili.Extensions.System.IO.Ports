# Aghili.Extensions.System.IO.Ports

[![](https://img.shields.io/github/license/aghili/Aghili.Extensions.System.IO.Ports.svg?style=flat-square)](https://github.com/aghili/Aghili.Extensions.System.IO.Ports/blob/master/LICENSE)
[![](https://img.shields.io/github/commit-activity/y/aghili/Aghili.Extensions.System.IO.Ports.svg?style=flat-square)](https://github.com/aghili/Aghili.Extensions.System.IO.Ports/commits/master)
[![](https://img.shields.io/github/issues/aghili/Aghili.Extensions.System.IO.Ports.svg?style=flat-square)](https://github.com/aghili/Aghili.Extensions.System.IO.Ports/issues)

Extension for Microsoft System.IO.Ports Package.

In this package, the ability to call asynchronously is added to the classes that do not have asynchronous capability

## Implemented classes

### SerialPort

#### Read methods

`ReadAsync` :

```cs
public ValueTask<int> ReadAsync(byte[] buffer,CancellationToken cancellationToken = default)
```

`ReadExistingAsync` :

```cs
public async ValueTask<string> ReadExistingAsync(CancellationToken cancellationToken = default)
```

`ReadByteAsync` :

```cs
public async ValueTask<byte> ReadByteAsync(CancellationToken cancellationToken = default)
```

`ReadCharAsync` :

```cs
public async ValueTask<char> ReadCharAsync(CancellationToken cancellationToken = default)
```

`ReadLineAsync` :

```cs
public async ValueTask<string> ReadLineAsync(CancellationToken cancellationToken = default)
```

`ReadTo` :

```cs
public async ValueTask<string> ReadTo(string value, CancellationToken cancellationToken = default)
```

`ReadAsync` :

```cs
public ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
```

`ReadAsync` :

```cs
public Task<int> ReadAsync(byte[] buffer,int offset,int count, CancellationToken cancellationToken = default)
```

#### Write methods

`WriteLineAsync` :

```cs
public ValueTask WriteLineAsync(string value, CancellationToken cancellationToken = default)
```

`WriteAsync` :

```cs
public Task WriteAsync(byte[] buffer,int offset,int count, CancellationToken cancellationToken = default)
```

`WriteAsync` :

```cs
public ValueTask WriteAsync(byte[] buffer, CancellationToken cancellationToken = default)
```

`WriteAsync` :

```cs
public ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
```

## How to get

[![](https://img.shields.io/nuget/dt/Aghili.Extensions.System.IO.Ports.svg?style=flat-square)](https://www.nuget.org/packages/Aghili.Extensions.System.IO.Ports)
[![](https://img.shields.io/nuget/v/Aghili.Extensions.System.IO.Ports?style=flat-square)](https://www.nuget.org/packages/Aghili.Extensions.System.IO.Ports)

This library is available as a NuGet package at [nuget.org](https://www.nuget.org/packages/Aghili.Extensions.System.IO.Ports/).

## Help me fund my own Death Star

[![](https://img.shields.io/badge/crypto-CoinPayments-8a00a3.svg?style=flat-square)](https://www.coinpayments.net/index.php?cmd=_donate&reset=1&merchant=xxxx&item_name=Donate&currency=USD&amountf=20.00000000&allow_amount=1&want_shipping=0&allow_extra=1)
[![](https://img.shields.io/badge/shetab-ZarinPal-8a00a3.svg?style=flat-square)](https://zarinp.al/@maghili)
[![](https://img.shields.io/badge/usd-Paypal-8a00a3.svg?style=flat-square)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=aghili@gmail.com&lc=US&item_name=Donate&no_note=0&cn=&curency_code=USD&bn=PP-DonationsBF:btn_donateCC_LG.gif:NonHosted)

**--OR--**

You can always donate your time by contributing to the project or by introducing it to others.

## License

MIT License

Copyright (c) 2010-2023 mostafa aghili

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
