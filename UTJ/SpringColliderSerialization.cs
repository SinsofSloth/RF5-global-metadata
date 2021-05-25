public static class SpringColliderSerialization // TypeDefIndex: 9149
{
	// Fields
	private const string SphereColliderToken = "sp";
	private const string CapsuleColliderToken = "cp";
	private const string PanelColliderToken = "pa";

	// Methods

	// RVA: 0x23999C0 Offset: 0x2399AC1 VA: 0x23999C0
	public static string BuildCollisionSetupString(GameObject colliderRoot) { }

	// RVA: 0x2399A70 Offset: 0x2399B71 VA: 0x2399A70
	private static void AppendColliders(CSVBuilder builder, GameObject colliderRoot) { }

	// RVA: 0x239C0D0 Offset: 0x239C1D1 VA: 0x239C0D0
	private static string GetComponentName(Component component) { }

	// RVA: 0x239C170 Offset: 0x239C271 VA: 0x239C170
	private static SpringColliderSerialization.TransformSerializer TransformToSerializer(Transform sourceTransform) { }

	// RVA: 0x239C2F0 Offset: 0x239C3F1 VA: 0x239C2F0
	private static SpringColliderSerialization.ColliderSerializerBaseInfo TransformToColliderSerializerBaseInfo(Transform sourceTransform, string colliderType) { }

	// RVA: 0x239C3A0 Offset: 0x239C4A1 VA: 0x239C3A0
	private static SpringColliderSerialization.SphereColliderSerializer SphereColliderToSerializer(SpringSphereCollider sourceCollider) { }

	// RVA: 0x239C4F0 Offset: 0x239C5F1 VA: 0x239C4F0
	private static SpringColliderSerialization.CapsuleColliderSerializer CapsuleColliderToSerializer(SpringCapsuleCollider sourceCollider) { }

	// RVA: 0x239C640 Offset: 0x239C741 VA: 0x239C640
	private static SpringColliderSerialization.PanelColliderSerializer PanelColliderToSerializer(SpringPanelCollider sourceCollider) { }

	// RVA: 0x239B770 Offset: 0x239B871 VA: 0x239B770
	private static void AppendDynamicsNulls(CSVBuilder builder, GameObject rootObject) { }

	// RVA: 0x239BB30 Offset: 0x239BC31 VA: 0x239BB30
	private static string BuildComponentDefinitionString(GameObject colliderRoot) { }

	// RVA: -1 Offset: -1
	private static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = '\x2c') { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E23D0 Offset: 0x23E24D1 VA: 0x23E23D0
	|-SpringColliderSerialization.AppendRecordItem<object>
	|-SpringColliderSerialization.AppendRecordItem<string>
	*/

	// RVA: 0x239C9D0 Offset: 0x239CAD1 VA: 0x239C9D0
	private static Transform CreateNewGameObject(Transform parent, string name) { }

	// RVA: 0x239CB00 Offset: 0x239CC01 VA: 0x239CB00
	private static Transform GetChildByName(Transform parent, string name) { }

	// RVA: -1 Offset: -1
	private static T TryToFindComponent<T>(GameObject gameObject, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265530 Offset: 0x2265631 VA: 0x2265530
	|-SpringColliderSerialization.TryToFindComponent<object>
	|-SpringColliderSerialization.TryToFindComponent<Renderer>
	*/

	// RVA: 0x239CC70 Offset: 0x239CD71 VA: 0x239CC70
	private static IEnumerable<SpringColliderSerialization.IColliderSerializer> SerializeColliderRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x239D1D0 Offset: 0x239D2D1 VA: 0x239D1D0
	private static IEnumerable<SpringColliderSerialization.TransformSerializer> SerializeTransformRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords) { }

	// RVA: 0x239D670 Offset: 0x239D771 VA: 0x239D670
	private static bool VerifyTransformRecord(SpringColliderSerialization.TransformSerializer transformSerializer, IEnumerable<string> validParentNames, out DynamicsSetup.ParseMessage error) { }

	// RVA: 0x239D800 Offset: 0x239D901 VA: 0x239D800
	private static bool VerifyTransformRecords(IEnumerable<SpringColliderSerialization.TransformSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringColliderSerialization.TransformSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x239DD30 Offset: 0x239DE31 VA: 0x239DD30
	private static bool VerifyColliderRecords(IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords, GameObject rootObject, IEnumerable<string> validParentNames, List<SpringColliderSerialization.IColliderSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors) { }

	// RVA: 0x239E4C0 Offset: 0x239E5C1 VA: 0x239E4C0
	private static GameObject BuildTransformFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.TransformSerializer serializer) { }

	// RVA: 0x239E670 Offset: 0x239E771 VA: 0x239E670
	private static bool BuildColliderFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.IColliderSerializer colliderSerializer) { }

	// RVA: 0x239E7F0 Offset: 0x239E8F1 VA: 0x239E7F0
	private static void BuildDynamicsNulls(Dictionary<string, Transform> objectMap, IEnumerable<SpringColliderSerialization.TransformSerializer> records) { }

	// RVA: 0x239ED10 Offset: 0x239EE11 VA: 0x239ED10
	private static void BuildComponents(Dictionary<string, Transform> objectMap, IEnumerable<TextRecordParsing.Record> records) { }
}

