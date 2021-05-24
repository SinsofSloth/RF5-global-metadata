[ComVisibleAttribute] // RVA: 0xB13F0 Offset: 0xB14F1 VA: 0xB13F0
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 1230
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x173C8B0 Offset: 0x173C9B1 VA: 0x173C8B0
	public void .ctor() { }

	// RVA: 0x175AE10 Offset: 0x175AF11 VA: 0x175AE10 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x175AFF0 Offset: 0x175B0F1 VA: 0x175AFF0
	private static void .cctor() { }
}

