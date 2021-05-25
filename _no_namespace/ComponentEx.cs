[ExtensionAttribute] // RVA: 0x146430 Offset: 0x146531 VA: 0x146430
public static class ComponentEx // TypeDefIndex: 7292
{
	// Methods

	[ExtensionAttribute] // RVA: 0x19F470 Offset: 0x19F571 VA: 0x19F470
	// RVA: 0x1FC6CB0 Offset: 0x1FC6DB1 VA: 0x1FC6CB0
	public static void SetGameObjectActive(Component self, bool isActive) { }

	[ExtensionAttribute] // RVA: 0x19F480 Offset: 0x19F581 VA: 0x19F480
	// RVA: 0x1FC6CF0 Offset: 0x1FC6DF1 VA: 0x1FC6CF0
	public static bool IsGameObjectActive(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F490 Offset: 0x19F591 VA: 0x19F490
	// RVA: -1 Offset: -1
	public static T AddComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEE00 Offset: 0x23BEF01 VA: 0x23BEE00
	|-ComponentEx.AddComponent<AriesElectricBall>
	|-ComponentEx.AddComponent<AssetCounter>
	|-ComponentEx.AddComponent<AudmuraLaser>
	|-ComponentEx.AddComponent<BeanSowingPlayer>
	|-ComponentEx.AddComponent<BehaviorTree>
	|-ComponentEx.AddComponent<BossProjectileOmen>
	|-ComponentEx.AddComponent<CharacterNearCullingController>
	|-ComponentEx.AddComponent<EmotionController>
	|-ComponentEx.AddComponent<FishSwim>
	|-ComponentEx.AddComponent<HasibirokouSonicStorm>
	|-ComponentEx.AddComponent<HasibirokouSonicWind>
	|-ComponentEx.AddComponent<IconLoading>
	|-ComponentEx.AddComponent<KyubiFireball>
	|-ComponentEx.AddComponent<ParticleDestroy>
	|-ComponentEx.AddComponent<SEController>
	|-ComponentEx.AddComponent<ReviatanWave>
	|-ComponentEx.AddComponent<SimpleTriggerEventDispatcher>
	|-ComponentEx.AddComponent<SnowmanPlayer>
	|-ComponentEx.AddComponent<object>
	|-ComponentEx.AddComponent<UIMainController>
	|-ComponentEx.AddComponent<CapsuleCollider>
	|-ComponentEx.AddComponent<EventTrigger>
	|-ComponentEx.AddComponent<YadokariBubble>
	|-ComponentEx.AddComponent<YadokariWave>
	*/

	[ExtensionAttribute] // RVA: 0x19F4A0 Offset: 0x19F5A1 VA: 0x19F4A0
	// RVA: -1 Offset: -1
	public static T SafeGetComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BF260 Offset: 0x23BF361 VA: 0x23BF260
	|-ComponentEx.SafeGetComponent<KrakenStickController>
	|-ComponentEx.SafeGetComponent<ParticleDestroy>
	|-ComponentEx.SafeGetComponent<SimpleHpBar>
	|-ComponentEx.SafeGetComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F4B0 Offset: 0x19F5B1 VA: 0x19F4B0
	// RVA: 0x1FC6D20 Offset: 0x1FC6E21 VA: 0x1FC6D20
	public static GameObject[] GetChildren(Component self, bool includeInactive = False) { }

	[ExtensionAttribute] // RVA: 0x19F4C0 Offset: 0x19F5C1 VA: 0x19F4C0
	// RVA: 0x1FC6EF0 Offset: 0x1FC6FF1 VA: 0x1FC6EF0
	public static GameObject[] GetChildrenWithoutGrandchildren(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F4D0 Offset: 0x19F5D1 VA: 0x19F4D0
	// RVA: -1 Offset: -1
	public static T[] GetComponentsInChildrenWithoutSelf<T>(Component self, bool includeInactive = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CCA0 Offset: 0x226CDA1 VA: 0x226CCA0
	|-ComponentEx.GetComponentsInChildrenWithoutSelf<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F4E0 Offset: 0x19F5E1 VA: 0x19F4E0
	// RVA: 0x1FC7300 Offset: 0x1FC7401 VA: 0x1FC7300
	public static void RemoveChildren(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F4F0 Offset: 0x19F5F1 VA: 0x19F4F0
	// RVA: -1 Offset: -1
	public static void RemoveComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CEDE0 Offset: 0x21CEEE1 VA: 0x21CEDE0
	|-ComponentEx.RemoveComponent<BeanSowingPlayer>
	|-ComponentEx.RemoveComponent<SnowmanPlayer>
	|-ComponentEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F500 Offset: 0x19F601 VA: 0x19F500
	// RVA: -1 Offset: -1
	public static void RemoveComponentImmediate<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CEE80 Offset: 0x21CEF81 VA: 0x21CEE80
	|-ComponentEx.RemoveComponentImmediate<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F510 Offset: 0x19F611 VA: 0x19F510
	// RVA: -1 Offset: -1
	public static void RemoveComponents<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CEF20 Offset: 0x21CF021 VA: 0x21CEF20
	|-ComponentEx.RemoveComponents<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F520 Offset: 0x19F621 VA: 0x19F520
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(Component self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C7F0 Offset: 0x281C8F1 VA: 0x281C7F0
	|-ComponentEx.HasComponent<Character>
	|-ComponentEx.HasComponent<MiningPoint>
	|-ComponentEx.HasComponent<MonsterControllerBase>
	|-ComponentEx.HasComponent<OnGroundItem>
	|-ComponentEx.HasComponent<object>
	|-ComponentEx.HasComponent<UISaveTopButtonWork>
	*/

	[ExtensionAttribute] // RVA: 0x19F530 Offset: 0x19F631 VA: 0x19F530
	// RVA: 0x1FC73F0 Offset: 0x1FC74F1 VA: 0x1FC73F0
	public static Transform Find(Component self, string name) { }

	[ExtensionAttribute] // RVA: 0x19F540 Offset: 0x19F641 VA: 0x19F540
	// RVA: 0x1FC7430 Offset: 0x1FC7531 VA: 0x1FC7430
	public static Transform FindDeep(Component self, string name, bool includeInactive = False) { }

	[ExtensionAttribute] // RVA: 0x19F550 Offset: 0x19F651 VA: 0x19F550
	// RVA: 0x1FC7510 Offset: 0x1FC7611 VA: 0x1FC7510
	public static GameObject FindGameObject(Component self, string name) { }

	[ExtensionAttribute] // RVA: 0x19F560 Offset: 0x19F661 VA: 0x19F560
	// RVA: 0x1FC75E0 Offset: 0x1FC76E1 VA: 0x1FC75E0
	public static GameObject FindGameObjectDeep(Component self, string name, bool includeInactive = False) { }

	[ExtensionAttribute] // RVA: 0x19F570 Offset: 0x19F671 VA: 0x19F570
	// RVA: -1 Offset: -1
	public static T FindComponent<T>(Component self, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEE90 Offset: 0x23BEF91 VA: 0x23BEE90
	|-ComponentEx.FindComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F580 Offset: 0x19F681 VA: 0x19F580
	// RVA: 0x1FC76B0 Offset: 0x1FC77B1 VA: 0x1FC76B0
	public static bool HasChild(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F590 Offset: 0x19F691 VA: 0x19F590
	// RVA: 0x1FC76F0 Offset: 0x1FC77F1 VA: 0x1FC76F0
	public static GameObject GetChild(Component self, int index) { }

	[ExtensionAttribute] // RVA: 0x19F5A0 Offset: 0x19F6A1 VA: 0x19F5A0
	// RVA: 0x1FC77C0 Offset: 0x1FC78C1 VA: 0x1FC77C0
	public static void SetParent(Component self, Component parent) { }

	[ExtensionAttribute] // RVA: 0x19F5B0 Offset: 0x19F6B1 VA: 0x19F5B0
	// RVA: 0x1FC7810 Offset: 0x1FC7911 VA: 0x1FC7810
	public static void SetParent(Component self, Component parent, bool worldPositionStays) { }

	[ExtensionAttribute] // RVA: 0x19F5C0 Offset: 0x19F6C1 VA: 0x19F5C0
	// RVA: 0x1FC7870 Offset: 0x1FC7971 VA: 0x1FC7870
	public static void SetParent(Component self, GameObject parent) { }

	[ExtensionAttribute] // RVA: 0x19F5D0 Offset: 0x19F6D1 VA: 0x19F5D0
	// RVA: 0x1FC78C0 Offset: 0x1FC79C1 VA: 0x1FC78C0
	public static void SetParent(Component self, GameObject parent, bool worldPositionStays) { }

	[ExtensionAttribute] // RVA: 0x19F5E0 Offset: 0x19F6E1 VA: 0x19F5E0
	// RVA: 0x1FC7920 Offset: 0x1FC7A21 VA: 0x1FC7920
	public static bool HasParent(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F5F0 Offset: 0x19F6F1 VA: 0x19F5F0
	// RVA: 0x1FC79B0 Offset: 0x1FC7AB1 VA: 0x1FC79B0
	public static GameObject GetParent(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F600 Offset: 0x19F701 VA: 0x19F600
	// RVA: 0x1FC7A70 Offset: 0x1FC7B71 VA: 0x1FC7A70
	public static GameObject GetRoot(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F610 Offset: 0x19F711 VA: 0x19F610
	// RVA: 0x1FC7B30 Offset: 0x1FC7C31 VA: 0x1FC7B30
	public static void SetLayer(Component self, string layerName) { }

	[ExtensionAttribute] // RVA: 0x19F620 Offset: 0x19F721 VA: 0x19F620
	// RVA: 0x1FC7B80 Offset: 0x1FC7C81 VA: 0x1FC7B80
	public static int GetLayer(Component self) { }

	[ExtensionAttribute] // RVA: 0x19F630 Offset: 0x19F731 VA: 0x19F630
	// RVA: 0x1FC7BB0 Offset: 0x1FC7CB1 VA: 0x1FC7BB0
	public static bool CompLayer(Component self, int layer) { }

	[ExtensionAttribute] // RVA: 0x19F640 Offset: 0x19F741 VA: 0x19F640
	// RVA: 0x1FC7BF0 Offset: 0x1FC7CF1 VA: 0x1FC7BF0
	public static bool CompLayerMask(Component self, int layerMask) { }

	[ExtensionAttribute] // RVA: 0x19F650 Offset: 0x19F751 VA: 0x19F650
	// RVA: 0x1FC7C40 Offset: 0x1FC7D41 VA: 0x1FC7C40
	public static void SetLayerRecursively(Component self, int layer) { }

	[ExtensionAttribute] // RVA: 0x19F660 Offset: 0x19F761 VA: 0x19F660
	// RVA: 0x1FC7EE0 Offset: 0x1FC7FE1 VA: 0x1FC7EE0
	public static void SetLayerRecursively(Component self, string layerName) { }

	[ExtensionAttribute] // RVA: 0x19F670 Offset: 0x19F771 VA: 0x19F670
	// RVA: -1 Offset: -1
	public static T GetCopyOf<T>(Component comp, T other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEF70 Offset: 0x23BF071 VA: 0x23BEF70
	|-ComponentEx.GetCopyOf<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F680 Offset: 0x19F781 VA: 0x19F680
	// RVA: -1 Offset: -1
	public static T AddComponent<T>(GameObject go, T toAdd) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BEE40 Offset: 0x23BEF41 VA: 0x23BEE40
	|-ComponentEx.AddComponent<object>
	*/

	// RVA: 0x1FC7F10 Offset: 0x1FC8011 VA: 0x1FC7F10
	public static void MeshNormalAverage(Mesh mesh) { }
}

