﻿using AAEmu.Commons.Network;
using AAEmu.Game.Models.Game.Skills.Static;

namespace AAEmu.Game.Models.Game.Skills
{
    public abstract class CastAction : PacketMarshaler
    {
        public CastType Type { get; set; }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write((byte) Type);
            return stream;
        }
    }

    public class CastSkill : CastAction
    {
        private uint _skillId;
        private ushort _tlId;

        public CastSkill(uint skillId, ushort tlId)
        {
            Type = CastType.Skill;
            _skillId = skillId;
            _tlId = tlId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(_skillId);
            stream.Write(_tlId);
            return stream;
        }
    }

    public class CastPlot : CastAction
    {
        private uint _plotId;
        private ushort _tlId;
        private uint _eventId;
        private uint _skillId;

        public CastPlot(uint plotId, ushort tlId, uint eventId, uint skillId)
        {
            Type = CastType.Plot;
            _plotId = plotId;
            _tlId = tlId;
            _eventId = eventId;
            _skillId = skillId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(_plotId); // type(id)
            stream.Write(_tlId);
            stream.Write(_eventId); // type(id)
            stream.Write(_skillId); // type(id)
            return stream;
        }
    }

    public class CastBuff : CastAction
    {
        private Effect _effect;

        public CastBuff(Effect effect)
        {
            Type = CastType.Buff;
            _effect = effect;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(_effect.Template.BuffId);
            stream.WriteBc(_effect.Owner.ObjId);
            stream.Write(_effect.Index);
            stream.Write(true); // t
            stream.Write(false); // t
            return stream;
        }
    }

    public class CastUnk2 : CastAction
    {
        public CastUnk2()
        {
            Type = CastType.Passive;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(0); // type(id), pt
            stream.Write(0); // buffId
            stream.WriteBc(0);
            return stream;
        }
    }

    public class CastUnk3 : CastAction
    {
        public CastUnk3()
        {
            Type = CastType.Doodad;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write(0); // type(id), dt
            stream.WriteBc(0);
            return stream;
        }
    }
}
