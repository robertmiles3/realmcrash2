using System;
using Realms;

namespace realmcrash.Models
{
    public class Item : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        public string Title { get; set; }
    }
}