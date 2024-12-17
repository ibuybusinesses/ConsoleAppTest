using ConsoleAppTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyStream input = new MyStream(System.Text.Encoding.UTF8.GetBytes("Hello test test test"));
			MyStream output = new MyStream();
			Copy(input, output);
		}		


		static void Copy(MyStream source, MyStream destination)
		{
			byte[] buffer = new byte[4096];
			int byteread;
			//source.CopyTo(destination);
			byteread = source.Read(buffer, 0, buffer.Length);
			while (byteread > 0)
			{
				destination.Write(buffer, 0, byteread);
				byteread = source.Read(buffer, 0, buffer.Length);
			}
		}
	}
}
