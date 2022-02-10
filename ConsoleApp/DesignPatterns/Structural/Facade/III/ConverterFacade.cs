using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Facade.III
{
    public class ConverterFacade : IXmlConverter, IJsonConverter, IByteArrayConverter
    {
        private IXmlConverter xmlConverter;
        private IJsonConverter jsonConverter;
        private IByteArrayConverter byteArrayConverter;

        public ConverterFacade(IXmlConverter xmlConverter, IJsonConverter jsonConverter, IByteArrayConverter byteArrayConverter)
        {
            this.xmlConverter = xmlConverter;
            this.jsonConverter = jsonConverter;
            this.byteArrayConverter = byteArrayConverter;
        }

        public string ToByteArray<T>(T item)
        {
            return byteArrayConverter.ToByteArray(item);
        }

        public string ToJson<T>(T item)
        {
            return jsonConverter.ToJson(item);
        }

        public string ToXml<T>(T item)
        {
            return xmlConverter.ToXml(item);
        }
    }
}
