// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getAttachedStickers.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLStickerSetCovered>"/>
	/// </summary>
	public partial class TLMessagesGetAttachedStickers : TLObject
	{
		public TLInputStickeredMediaBase Media { get; set; }

		public TLMessagesGetAttachedStickers() { }
		public TLMessagesGetAttachedStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetAttachedStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Media = TLFactory.Read<TLInputStickeredMediaBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Media);
		}
	}
}