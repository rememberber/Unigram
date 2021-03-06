// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method invokeWithLayer.
	/// Returns <see cref="Telegram.Api.TL.TLObject"/>
	/// </summary>
	public partial class TLInvokeWithLayer : TLObject
	{
		public Int32 Layer { get; set; }
		public TLObject Query { get; set; }

		public TLInvokeWithLayer() { }
		public TLInvokeWithLayer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InvokeWithLayer; } }

		public override void Read(TLBinaryReader from)
		{
			Layer = from.ReadInt32();
			Query = TLFactory.Read<TLObject>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDA9B0D0D);
			to.Write(Layer);
			to.WriteObject(Query);
		}
	}
}