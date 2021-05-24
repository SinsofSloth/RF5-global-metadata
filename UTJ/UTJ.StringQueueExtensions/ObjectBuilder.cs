[ExtensionAttribute] // RVA: 0x147B90 Offset: 0x147C91 VA: 0x147B90
public static class ObjectBuilder // TypeDefIndex: 9193
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1A97E0 Offset: 0x1A98E1 VA: 0x1A97E0
	// RVA: 0x23A3AC0 Offset: 0x23A3BC1 VA: 0x23A3AC0
	public static float DequeueFloat(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x1A97F0 Offset: 0x1A98F1 VA: 0x1A97F0
	// RVA: 0x23A3B20 Offset: 0x23A3C21 VA: 0x23A3B20
	public static int DequeueInt(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x1A9800 Offset: 0x1A9901 VA: 0x1A9800
	// RVA: 0x23A3B80 Offset: 0x23A3C81 VA: 0x23A3B80
	public static Vector3 DequeueVector3(Queue<string> queue) { }

	[ExtensionAttribute] // RVA: 0x1A9810 Offset: 0x1A9911 VA: 0x1A9810
	// RVA: 0x23A3C50 Offset: 0x23A3D51 VA: 0x23A3C50
	public static Transform DequeueTransform(Queue<string> queue, GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x1A9820 Offset: 0x1A9921 VA: 0x1A9820
	// RVA: 0x23A3440 Offset: 0x23A3541 VA: 0x23A3440
	public static bool DequeueComponent(Queue<string> queue, Component component, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x1A9830 Offset: 0x1A9931 VA: 0x1A9830
	// RVA: 0x23A3FC0 Offset: 0x23A40C1 VA: 0x23A3FC0
	public static void DequeueFields(Queue<string> queue, Type classType, object item, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x1A9840 Offset: 0x1A9941 VA: 0x1A9840
	// RVA: -1 Offset: -1
	public static void DequeueFields<T>(Queue<string> queue, T item, string firstOptionalField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E24E0 Offset: 0x23E25E1 VA: 0x23E24E0
	|-ObjectBuilder.DequeueFields<object>
	*/

	[ExtensionAttribute] // RVA: 0x1A9850 Offset: 0x1A9951 VA: 0x1A9850
	// RVA: 0x23A4500 Offset: 0x23A4601 VA: 0x23A4500
	public static void DequeueFields(Queue<string> queue, Type classType, object item, string firstOptionalField) { }

	[ExtensionAttribute] // RVA: 0x1A9860 Offset: 0x1A9961 VA: 0x1A9860
	// RVA: -1 Offset: -1
	public static T DequeueObject<T>(Queue<string> queue, string firstOptionalField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22655B0 Offset: 0x22656B1 VA: 0x22655B0
	|-ObjectBuilder.DequeueObject<object>
	|-ObjectBuilder.DequeueObject<SpringBoneSerialization.SpringBoneBaseSerializer>
	*/

	[ExtensionAttribute] // RVA: 0x1A9870 Offset: 0x1A9971 VA: 0x1A9870
	// RVA: 0x23A4660 Offset: 0x23A4761 VA: 0x23A4660
	public static object DequeueObject(Queue<string> queue, Type type, string firstOptionalField) { }

	// RVA: 0x23A46C0 Offset: 0x23A47C1 VA: 0x23A46C0
	private static object ParsePrimitiveType(Type type, string valueSource) { }

	// RVA: 0x23A4900 Offset: 0x23A4A01 VA: 0x23A4900
	private static object ParseEnum(Type type, string valueSource) { }

	[ExtensionAttribute] // RVA: 0x1A9880 Offset: 0x1A9981 VA: 0x1A9880
	// RVA: 0x23A40B0 Offset: 0x23A41B1 VA: 0x23A40B0
	private static object GetValueByType(Queue<string> queue, Type type, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	[ExtensionAttribute] // RVA: 0x1A9890 Offset: 0x1A9991 VA: 0x1A9890
	// RVA: 0x23A50E0 Offset: 0x23A51E1 VA: 0x23A50E0
	private static Array BuildArray(Queue<string> queue, Type elementType, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps) { }

	// RVA: 0x23A4D60 Offset: 0x23A4E61 VA: 0x23A4D60
	private static Component FindComponent(Type type, GameObject root, string objectName) { }
}

