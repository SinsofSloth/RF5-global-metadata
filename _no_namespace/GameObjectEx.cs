[ExtensionAttribute] // RVA: 0x146440 Offset: 0x146541 VA: 0x146440
public static class GameObjectEx // TypeDefIndex: 7297
{
	// Fields
	public static readonly string CLONE_SUFFIX; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x19F690 Offset: 0x19F791 VA: 0x19F690
	// RVA: 0x22A4650 Offset: 0x22A4751 VA: 0x22A4650
	public static bool IsActive(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F6A0 Offset: 0x19F7A1 VA: 0x19F6A0
	// RVA: 0x22A4670 Offset: 0x22A4771 VA: 0x22A4670
	public static string FullName(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F6B0 Offset: 0x19F7B1 VA: 0x19F6B0
	// RVA: 0x22A4840 Offset: 0x22A4941 VA: 0x22A4840
	public static void TrimCloneSuffix(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F6C0 Offset: 0x19F7C1 VA: 0x19F6C0
	// RVA: -1 Offset: -1
	public static T SafeGetComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1350 Offset: 0x23C1451 VA: 0x23C1350
	|-GameObjectEx.SafeGetComponent<AssetCounter>
	|-GameObjectEx.SafeGetComponent<CharacterMovement>
	|-GameObjectEx.SafeGetComponent<DamageActionController>
	|-GameObjectEx.SafeGetComponent<GansekiDragonRockController>
	|-GameObjectEx.SafeGetComponent<MonsterSoulController>
	|-GameObjectEx.SafeGetComponent<object>
	|-GameObjectEx.SafeGetComponent<NavMeshAgent>
	|-GameObjectEx.SafeGetComponent<Rigidbody>
	*/

	[ExtensionAttribute] // RVA: 0x19F6D0 Offset: 0x19F7D1 VA: 0x19F6D0
	// RVA: 0x22A4940 Offset: 0x22A4A41 VA: 0x22A4940
	public static Component SafeGetComponent(GameObject self, Type type) { }

	[ExtensionAttribute] // RVA: 0x19F6E0 Offset: 0x19F7E1 VA: 0x19F6E0
	// RVA: 0x22A4A00 Offset: 0x22A4B01 VA: 0x22A4A00
	public static GameObject[] GetChildren(GameObject self, bool includeInactive = False) { }

	[ExtensionAttribute] // RVA: 0x19F6F0 Offset: 0x19F7F1 VA: 0x19F6F0
	// RVA: 0x22A4BD0 Offset: 0x22A4CD1 VA: 0x22A4BD0
	public static GameObject[] GetChildrenWithoutGrandchildren(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F700 Offset: 0x19F801 VA: 0x19F700
	// RVA: -1 Offset: -1
	public static T[] GetComponentsInChildrenWithoutSelf<T>(GameObject self, bool includeInactive = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D3E0 Offset: 0x226D4E1 VA: 0x226D3E0
	|-GameObjectEx.GetComponentsInChildrenWithoutSelf<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F710 Offset: 0x19F811 VA: 0x19F710
	// RVA: 0x22A4FE0 Offset: 0x22A50E1 VA: 0x22A4FE0
	public static void RemoveChildren(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F720 Offset: 0x19F821 VA: 0x19F720
	// RVA: -1 Offset: -1
	public static void RemoveComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D10A0 Offset: 0x21D11A1 VA: 0x21D10A0
	|-GameObjectEx.RemoveComponent<MonsterDoctor>
	|-GameObjectEx.RemoveComponent<SimpleHpBar>
	|-GameObjectEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F730 Offset: 0x19F831 VA: 0x19F730
	// RVA: -1 Offset: -1
	public static void RemoveComponentImmediate<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1140 Offset: 0x21D1241 VA: 0x21D1140
	|-GameObjectEx.RemoveComponentImmediate<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F740 Offset: 0x19F841 VA: 0x19F740
	// RVA: -1 Offset: -1
	public static void RemoveComponents<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D11E0 Offset: 0x21D12E1 VA: 0x21D11E0
	|-GameObjectEx.RemoveComponents<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F750 Offset: 0x19F851 VA: 0x19F750
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(GameObject self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25191B0 Offset: 0x25192B1 VA: 0x25191B0
	|-GameObjectEx.HasComponent<CellController>
	|-GameObjectEx.HasComponent<WaterPointFurniture>
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F760 Offset: 0x19F861 VA: 0x19F760
	// RVA: 0x22A5100 Offset: 0x22A5201 VA: 0x22A5100
	public static bool HasComponent(GameObject self, Type type) { }

	[ExtensionAttribute] // RVA: 0x19F770 Offset: 0x19F871 VA: 0x19F770
	// RVA: 0x22A51A0 Offset: 0x22A52A1 VA: 0x22A51A0
	public static bool HasComponent(GameObject self, string typeName) { }

	[ExtensionAttribute] // RVA: 0x19F780 Offset: 0x19F881 VA: 0x19F780
	// RVA: 0x22A5240 Offset: 0x22A5341 VA: 0x22A5240
	public static Transform Find(GameObject self, string name) { }

	[ExtensionAttribute] // RVA: 0x19F790 Offset: 0x19F891 VA: 0x19F790
	// RVA: 0x22A5280 Offset: 0x22A5381 VA: 0x22A5280
	public static GameObject FindGameObject(GameObject self, string name) { }

	[ExtensionAttribute] // RVA: 0x19F7A0 Offset: 0x19F8A1 VA: 0x19F7A0
	// RVA: 0x22A5350 Offset: 0x22A5451 VA: 0x22A5350
	public static GameObject FindGameObjectDeep(GameObject self, string name, bool includeInactive = False) { }

	[ExtensionAttribute] // RVA: 0x19F7B0 Offset: 0x19F8B1 VA: 0x19F7B0
	// RVA: -1 Offset: -1
	public static T FindComponent<T>(GameObject self, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C1270 Offset: 0x23C1371 VA: 0x23C1270
	|-GameObjectEx.FindComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F7C0 Offset: 0x19F8C1 VA: 0x19F7C0
	// RVA: 0x22A5440 Offset: 0x22A5541 VA: 0x22A5440
	public static bool HasChild(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F7D0 Offset: 0x19F8D1 VA: 0x19F7D0
	// RVA: 0x22A5480 Offset: 0x22A5581 VA: 0x22A5480
	public static GameObject GetChild(GameObject self, int index) { }

	[ExtensionAttribute] // RVA: 0x19F7E0 Offset: 0x19F8E1 VA: 0x19F7E0
	// RVA: 0x22A5550 Offset: 0x22A5651 VA: 0x22A5550
	public static void SetParent(GameObject self, Component parent, bool worldPositionStays = True) { }

	[ExtensionAttribute] // RVA: 0x19F7F0 Offset: 0x19F8F1 VA: 0x19F7F0
	// RVA: 0x22A55B0 Offset: 0x22A56B1 VA: 0x22A55B0
	public static void SetParent(GameObject self, GameObject parent, bool worldPositionStays = True) { }

	[ExtensionAttribute] // RVA: 0x19F800 Offset: 0x19F901 VA: 0x19F800
	// RVA: 0x22A5610 Offset: 0x22A5711 VA: 0x22A5610
	public static bool HasParent(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F810 Offset: 0x19F911 VA: 0x19F810
	// RVA: 0x22A4780 Offset: 0x22A4881 VA: 0x22A4780
	public static GameObject GetParent(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F820 Offset: 0x19F921 VA: 0x19F820
	// RVA: 0x22A56A0 Offset: 0x22A57A1 VA: 0x22A56A0
	public static GameObject GetRoot(GameObject self) { }

	[ExtensionAttribute] // RVA: 0x19F830 Offset: 0x19F931 VA: 0x19F830
	// RVA: 0x22A5760 Offset: 0x22A5861 VA: 0x22A5760
	public static void SetLayer(GameObject self, string layerName) { }

	[ExtensionAttribute] // RVA: 0x19F840 Offset: 0x19F941 VA: 0x19F840
	// RVA: 0x22A57A0 Offset: 0x22A58A1 VA: 0x22A57A0
	public static void SetLayerRecursively(GameObject self, int layer) { }

	[ExtensionAttribute] // RVA: 0x19F850 Offset: 0x19F951 VA: 0x19F850
	// RVA: 0x22A5A70 Offset: 0x22A5B71 VA: 0x22A5A70
	public static void SetLayerRecursively(GameObject self, string layerName) { }

	// RVA: 0x22A5B00 Offset: 0x22A5C01 VA: 0x22A5B00
	private static void .cctor() { }
}

