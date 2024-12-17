using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
	internal class MyStream : Stream
	{
		private MemoryStream _stream;

		public MyStream()
		{
			_stream = new MemoryStream();
		}


		public MyStream(byte[] data)
		{
			_stream = new MemoryStream(data);
		}
		public override bool CanRead => throw new NotImplementedException();

		public override bool CanSeek => throw new NotImplementedException();

		public override bool CanWrite => throw new NotImplementedException();

		public override long Length => throw new NotImplementedException();

		public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public override void Flush()
		{
			throw new NotImplementedException();
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return _stream.Read(buffer, offset, count);
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotImplementedException();
		}

		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			_stream.Write(buffer, offset, count);
		}
	}
}
