﻿using System;

namespace Nexus.ParticipantLibrary.ApiContract.Dtos
{
    public class ParticipantLibraryItemType
    {
        public Guid NexusKey { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("An {GetType().Name} with Key:'{NexusKey}' Id:'{Id}' Name:'{Name}'");
        }
    }
}
