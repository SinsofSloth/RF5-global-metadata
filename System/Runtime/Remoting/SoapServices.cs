[ComVisibleAttribute] // RVA: 0xB0B00 Offset: 0xB0C01 VA: 0xB0B00
public class SoapServices // TypeDefIndex: 1123
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x15FBAA0 Offset: 0x15FBBA1 VA: 0x15FBAA0
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x15FBAF0 Offset: 0x15FBBF1 VA: 0x15FBAF0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x15FBB40 Offset: 0x15FBC41 VA: 0x15FBB40
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x15FBB90 Offset: 0x15FBC91 VA: 0x15FBB90
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x15FBE00 Offset: 0x15FBF01 VA: 0x15FBE00
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x15FBE80 Offset: 0x15FBF81 VA: 0x15FBE80
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x15FBFB0 Offset: 0x15FC0B1 VA: 0x15FBFB0
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x15FC0D0 Offset: 0x15FC1D1 VA: 0x15FC0D0
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x15FC170 Offset: 0x15FC271 VA: 0x15FC170
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x15FC210 Offset: 0x15FC311 VA: 0x15FC210
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x15FC320 Offset: 0x15FC421 VA: 0x15FC320
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x15FC400 Offset: 0x15FC501 VA: 0x15FC400
	public static void PreLoad(Type type) { }

	// RVA: 0x15FCBC0 Offset: 0x15FCCC1 VA: 0x15FCBC0
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x15FCA40 Offset: 0x15FCB41 VA: 0x15FCA40
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x15FBD50 Offset: 0x15FBE51 VA: 0x15FBD50
	private static string EncodeNs(string ns) { }

	// RVA: 0x15FCD50 Offset: 0x15FCE51 VA: 0x15FCD50
	private static void .cctor() { }
}

