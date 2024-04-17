using Microsoft.Xna.Framework.Content;
using System.Text.Json;

namespace ANO.MonoGame.Content.Pipeline.Types.Readers
{
    public class JSONContentTypeReader<T> : ContentTypeReader<T>
    {
        protected override T Read(ContentReader input, T existingInstance)
        {
            string json = input.ReadString();
            T result = JsonSerializer.Deserialize<T>(json);
            return result;
        }
    }
}
