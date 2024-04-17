using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ANO.MonoGame.Content.Pipeline.Types.Readers
{
    public class TiledMapContentTypeReader<TiledMapModel> : ContentTypeReader<TiledMapModel>
    {
        protected override TiledMapModel Read(ContentReader input, TiledMapModel existingInstance)
        {
            var serializer = new XmlSerializer(typeof(TiledMapModel));
            TiledMapModel result;
            string xml = input.ReadString();

            using (TextReader reader = new StringReader(xml))
            {
                result = (TiledMapModel)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
