using System;
using System.Collections.Generic;
using Realms;

namespace realmcrash.Models
{
    public class Folder : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        public string Title { get; set; }

        // References
        public IList<Item> Items { get; }
    }
}