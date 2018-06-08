﻿using GFDLibrary.IO;

namespace GFDLibrary
{
    public sealed class AnimationExtraData : Resource
    {
        public override ResourceType ResourceType => ResourceType.AnimationExtraData;

        public Animation Field00 { get; set; }

        public float Field10 { get; set; }

        public Animation Field04 { get; set; }

        public float Field14 { get; set; }

        public Animation Field08 { get; set; }

        public float Field18 { get; set; }

        public Animation Field0C { get; set; }

        public float Field1C { get; set; }

        public AnimationExtraData()
        {
        }

        public AnimationExtraData(uint version) : base(version)
        {
            
        }

        internal override void Read( ResourceReader reader )
        {
            Field00 = reader.ReadResource<Animation>( Version );
            Field10 = reader.ReadSingle();
            Field04 = reader.ReadResource<Animation>( Version );
            Field14 = reader.ReadSingle();
            Field08 = reader.ReadResource<Animation>( Version );
            Field18 = reader.ReadSingle();
            Field0C = reader.ReadResource<Animation>( Version );
            Field1C = reader.ReadSingle();
        }

        internal override void Write( ResourceWriter writer )
        {
            writer.WriteResource( Field00 );
            writer.WriteSingle( Field10 );
            writer.WriteResource( Field04 );
            writer.WriteSingle( Field14 );
            writer.WriteResource( Field08 );
            writer.WriteSingle( Field18 );
            writer.WriteResource( Field0C );
            writer.WriteSingle( Field1C );
        }
    }
}