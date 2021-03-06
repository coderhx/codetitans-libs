#region License
/*
    Copyright (c) 2010, Pawe� Hofman (CodeTitans)
    All Rights Reserved.

    Licensed under the Apache License version 2.0.
    For more information please visit:

    http://codetitans.codeplex.com/license
        or
    http://www.apache.org/licenses/


    For latest source code, documentation, samples
    and more information please visit:

    http://codetitans.codeplex.com/
*/
#endregion

using System;
using System.Globalization;
using CodeTitans.JSon.Objects.Mutable;

namespace CodeTitans.JSon.Objects
{
    internal class JSonDecimalInt32Object : JSonDecimalObject, IJSonWritable
    {
        private Int32 _data;

        /// <summary>
        /// Init constructor.
        /// </summary>
        public JSonDecimalInt32Object(Int32 data)
        {
            _data = data;
        }

        /// <summary>
        /// Gets or sets the value of internal data.
        /// </summary>
        protected Int32 Data
        {
            get { return _data; }
            set { _data = value; }
        }

        protected override IJSonMutableObject GetMutableCopy()
        {
            return new JSonMutableDecimalInt32Object(_data);
        }

        protected override IJSonObject GetImmutableCopy()
        {
            return new JSonDecimalInt32Object(_data);
        }

        protected override string GetStringValue()
        {
            return _data.ToString(CultureInfo.InvariantCulture);
        }

        protected override int GetInt32Value()
        {
            return _data;
        }

        protected override uint GetUInt32Value()
        {
            return (uint)_data;
        }

        protected override long GetInt64Value()
        {
            return _data;
        }

        protected override ulong GetUInt64Value()
        {
            return (ulong)_data;
        }

        protected override float GetSingleValue()
        {
            return _data;
        }

        protected override double GetDoubleValue()
        {
            return _data;
        }

        protected override decimal GetDecimalValue()
        {
            return new Decimal(_data);
        }

        protected override bool GetBooleanValue()
        {
            return _data != 0;
        }

        protected override object GetObjectValue()
        {
            return _data;
        }

        #region IJSonWritable Members

        void IJSonWritable.Write(IJSonWriter output)
        {
            output.WriteValue(_data);
        }

        #endregion
    }
}