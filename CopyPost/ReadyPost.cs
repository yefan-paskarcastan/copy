//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyPost
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReadyPost
    {
        public int idReadyPost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TorrentFile { get; set; }
        public Nullable<System.DateTime> FoundedTime { get; set; }
        public int FoundPost_idFoundPost { get; set; }
        public int FoundPost_TorrentTracker_idTorrentTracker { get; set; }
    
        public virtual FoundPost FoundPost { get; set; }
    }
}
