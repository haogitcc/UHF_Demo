using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LibUsbDotNet;
using LibUsbDotNet.Main;

namespace Reader
{
    class USBStream : Stream
    {
        private UsbDevice device;
        private UsbEndpointReader reader;
        private UsbEndpointWriter writer;
        public USBStream(UsbDevice device)
        {
            this.device = device;
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            switch (this.reader.Read(buffer, 1000, out count))
            {
                case ErrorCode.Ok:
                    return 0;
                default:
                    return -1;
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            this.writer.Write(buffer, 1000,out count);
        }

         public void Dispose()
        {
            this.device.Close();
        }

         public override bool CanRead
         {
             get { throw new NotImplementedException(); }
         }

         public override bool CanSeek
         {
             get { throw new NotImplementedException(); }
         }

         public override bool CanWrite
         {
             get { throw new NotImplementedException(); }
         }

         public override void Flush()
         {
             throw new NotImplementedException();
         }

         public override long Length
         {
             get { throw new NotImplementedException(); }
         }

         public override long Position
         {
             get
             {
                 throw new NotImplementedException();
             }
             set
             {
                 throw new NotImplementedException();
             }
         }

         public override long Seek(long offset, SeekOrigin origin)
         {
             throw new NotImplementedException();
         }

         public override void SetLength(long value)
         {
             throw new NotImplementedException();
         }
    }
}
