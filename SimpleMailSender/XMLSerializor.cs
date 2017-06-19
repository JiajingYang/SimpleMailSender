using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SimpleMailSender
{
    public static class XmlSerializor
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string XmlSerialize<T>(this T entity)
        {
            StringBuilder buffer = new StringBuilder();

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StringWriter(buffer))
            {
                serializer.Serialize(writer, entity);
            }

            return buffer.ToString();
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T XmlDeSerialize<T>(this string xmlString)
        {
            T cloneObject = default(T);

            StringBuilder buffer = new StringBuilder();
            buffer.Append(xmlString);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextReader reader = new StringReader(buffer.ToString()))
            {
                Object obj = serializer.Deserialize(reader);
                cloneObject = (T)obj;
            }
            return cloneObject;
        }
    }
}
