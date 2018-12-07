using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Reactions.Models
{
    public enum MediaType
    {
        PNG, 
        JPG,
        GIF,
        WEBM,
        WEBP,
    }

    public static class MediaTypeConverter
    {
       public static string GetMimeType(MediaType type)
       {
            string mime;
            switch (type)
            {
                case MediaType.PNG:
                    mime = "image/png";
                    break;
                case MediaType.JPG:
                    mime = "image/jpeg";
                    break;
                case MediaType.GIF:
                    mime = "image/gif";
                    break;
                case MediaType.WEBM:
                    mime = "video/webm";
                    break;
                case MediaType.WEBP:
                    mime = "image/webp";
                    break;
                default:
                    throw new ArgumentException();
            }
            return mime;
       }

        public static MediaType GetMediaType(string mime)
        {
            string input = mime.ToLower();
            MediaType type;
            switch (input)
            {
                case "image/png":
                    type = MediaType.PNG;
                    break;
                case "image/jpg":
                case "image/jpeg":
                    type = MediaType.JPG;
                    break;
                case "image/gif":
                    type = MediaType.GIF;
                    break;
                case "video/webm":
                    type = MediaType.WEBM;
                    break;
                case "image/webp":
                    type = MediaType.WEBP;
                    break;
                default:
                    throw new ArgumentException();
            }
            return type;
        }
    }

    
}
