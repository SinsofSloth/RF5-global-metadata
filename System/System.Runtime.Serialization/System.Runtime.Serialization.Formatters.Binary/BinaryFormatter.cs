[ComVisibleAttribute] // RVA: 0xB0920 Offset: 0xB0A21 VA: 0xB0920
public sealed class BinaryFormatter // TypeDefIndex: 1077
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x1602CA0 Offset: 0x1602DA1 VA: 0x1602CA0
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1602CB0 Offset: 0x1602DB1 VA: 0x1602CB0 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x1602CC0 Offset: 0x1602DC1 VA: 0x1602CC0
	public void .ctor() { }

	// RVA: 0x15F6410 Offset: 0x15F6511 VA: 0x15F6410
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x15FA250 Offset: 0x15FA351 VA: 0x15FA250 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x1602D50 Offset: 0x1602E51 VA: 0x1602D50
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x1602D40 Offset: 0x1602E41 VA: 0x1602D40 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x15FA0D0 Offset: 0x15FA1D1 VA: 0x15FA0D0 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x1603580 Offset: 0x1603681 VA: 0x1603580 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x1603590 Offset: 0x1603691 VA: 0x1603590
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x1603D10 Offset: 0x1603E11 VA: 0x1603D10
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x1603F70 Offset: 0x1604071 VA: 0x1603F70
	private static void .cctor() { }
}

