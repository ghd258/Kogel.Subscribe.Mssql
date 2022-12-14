using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Buffers;
using Kogel.Slave.Mysql.Extension;

namespace Kogel.Slave.Mysql
{
    class LongType : IMySQLDataType
    {
        public object ReadValue(ref SequenceReader<byte> reader, int meta)
        {
            return reader.ReadInteger(4);
        }
    }
}