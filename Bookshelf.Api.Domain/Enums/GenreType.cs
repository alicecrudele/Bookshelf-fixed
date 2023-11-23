﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookshelf.Api.Domain.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenreType
    {
       fiction,
       mystery,
       thriller,
       horror,
       historical,
       romance,
       western,
       science_fiction,
       fantasy,
       poetry,
    }
}
