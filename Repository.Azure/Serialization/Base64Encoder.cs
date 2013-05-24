﻿using System;

namespace Repository.Azure.Serialization
{
    public class Base64Encoder<T> : Encoder<T>
    {
        //===============================================================
        public Base64Encoder(ISerializer<T> serializer)
            : base(serializer)
        {}
        //===============================================================
        protected override byte[] EncodeString(String str)
        {
            return Convert.FromBase64String(str);
        }
        //===============================================================
        protected override string DecodeString(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        //===============================================================
    }
}