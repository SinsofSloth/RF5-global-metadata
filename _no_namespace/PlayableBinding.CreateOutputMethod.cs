[VisibleToOtherModulesAttribute] // RVA: 0xC8C50 Offset: 0xC8D51 VA: 0xC8C50
internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3350
{
	// Methods

	// RVA: 0x2B6DD40 Offset: 0x2B6DE41 VA: 0x2B6DD40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2B6D8D0 Offset: 0x2B6D9D1 VA: 0x2B6D8D0 Slot: 13
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	// RVA: 0x2B6DD60 Offset: 0x2B6DE61 VA: 0x2B6DD60 Slot: 14
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	// RVA: 0x2B6DE00 Offset: 0x2B6DF01 VA: 0x2B6DE00 Slot: 15
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }
}

