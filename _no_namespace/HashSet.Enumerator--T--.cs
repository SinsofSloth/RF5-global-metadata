[Serializable]
public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2745
{
	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DC20 Offset: 0x39DD21 VA: 0x39DC20
	|-HashSet.Enumerator<int>..ctor
	|
	|-RVA: 0x39DD50 Offset: 0x39DE51 VA: 0x39DD50
	|-HashSet.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x39DE80 Offset: 0x39DF81 VA: 0x39DE80
	|-HashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x39DFB0 Offset: 0x39E0B1 VA: 0x39DFB0
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x39E0E0 Offset: 0x39E1E1 VA: 0x39E0E0
	|-HashSet.Enumerator<Edge>..ctor
	|
	|-RVA: 0x39E210 Offset: 0x39E311 VA: 0x39E210
	|-HashSet.Enumerator<AsyncOperationHandle>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DED0 Offset: 0x39DFD1 VA: 0x39DED0
	|-HashSet.Enumerator<ActorController>.Dispose
	|-HashSet.Enumerator<EnvironmentSoundPointController>.Dispose
	|-HashSet.Enumerator<FieldHideItemSpawner>.Dispose
	|-HashSet.Enumerator<FieldItemSpawner>.Dispose
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawner>.Dispose
	|-HashSet.Enumerator<FieldRewardTreasureBoxSpawner>.Dispose
	|-HashSet.Enumerator<FieldUniqueTreasureBoxSpawner>.Dispose
	|-HashSet.Enumerator<MaterialChangeTime>.Dispose
	|-HashSet.Enumerator<ObjectChangeTime>.Dispose
	|-HashSet.Enumerator<RendererChangeTime>.Dispose
	|-HashSet.Enumerator<TextureChangeByFlag>.Dispose
	|-HashSet.Enumerator<VisibleChangeByFlag>.Dispose
	|-HashSet.Enumerator<BaseSpriteItemData>.Dispose
	|-HashSet.Enumerator<GimmickBase>.Dispose
	|-HashSet.Enumerator<MiningPoint>.Dispose
	|-HashSet.Enumerator<SEController>.Dispose
	|-HashSet.Enumerator<SeasonChangeObject>.Dispose
	|-HashSet.Enumerator<SeasonVisibleObject>.Dispose
	|-HashSet.Enumerator<Func<IEnumerator>>.Dispose
	|-HashSet.Enumerator<LabelScopeInfo>.Dispose
	|-HashSet.Enumerator<ParameterExpression>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<TeleportDragonRope>.Dispose
	|-HashSet.Enumerator<Collider>.Dispose
	|-HashSet.Enumerator<Material>.Dispose
	|-HashSet.Enumerator<Object>.Dispose
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.Dispose
	|-HashSet.Enumerator<IClippable>.Dispose
	|-HashSet.Enumerator<MaskableGraphic>.Dispose
	|-HashSet.Enumerator<Text>.Dispose
	|
	|-RVA: 0x39DDA0 Offset: 0x39DEA1 VA: 0x39DDA0
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawnID>.Dispose
	|-HashSet.Enumerator<ItemID>.Dispose
	|-HashSet.Enumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x39DC70 Offset: 0x39DD71 VA: 0x39DC70
	|-HashSet.Enumerator<int>.Dispose
	|
	|-RVA: 0x39E000 Offset: 0x39E101 VA: 0x39E000
	|-HashSet.Enumerator<uint>.Dispose
	|
	|-RVA: 0x39E130 Offset: 0x39E231 VA: 0x39E130
	|-HashSet.Enumerator<Edge>.Dispose
	|
	|-RVA: 0x39E270 Offset: 0x39E371 VA: 0x39E270
	|-HashSet.Enumerator<AsyncOperationHandle>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DEE0 Offset: 0x39DFE1 VA: 0x39DEE0
	|-HashSet.Enumerator<ActorController>.MoveNext
	|-HashSet.Enumerator<EnvironmentSoundPointController>.MoveNext
	|-HashSet.Enumerator<FieldHideItemSpawner>.MoveNext
	|-HashSet.Enumerator<FieldItemSpawner>.MoveNext
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawner>.MoveNext
	|-HashSet.Enumerator<FieldRewardTreasureBoxSpawner>.MoveNext
	|-HashSet.Enumerator<FieldUniqueTreasureBoxSpawner>.MoveNext
	|-HashSet.Enumerator<MaterialChangeTime>.MoveNext
	|-HashSet.Enumerator<ObjectChangeTime>.MoveNext
	|-HashSet.Enumerator<RendererChangeTime>.MoveNext
	|-HashSet.Enumerator<TextureChangeByFlag>.MoveNext
	|-HashSet.Enumerator<VisibleChangeByFlag>.MoveNext
	|-HashSet.Enumerator<BaseSpriteItemData>.MoveNext
	|-HashSet.Enumerator<GimmickBase>.MoveNext
	|-HashSet.Enumerator<MiningPoint>.MoveNext
	|-HashSet.Enumerator<SEController>.MoveNext
	|-HashSet.Enumerator<SeasonChangeObject>.MoveNext
	|-HashSet.Enumerator<SeasonVisibleObject>.MoveNext
	|-HashSet.Enumerator<Func<IEnumerator>>.MoveNext
	|-HashSet.Enumerator<LabelScopeInfo>.MoveNext
	|-HashSet.Enumerator<ParameterExpression>.MoveNext
	|-HashSet.Enumerator<object>.MoveNext
	|-HashSet.Enumerator<TeleportDragonRope>.MoveNext
	|-HashSet.Enumerator<Collider>.MoveNext
	|-HashSet.Enumerator<Material>.MoveNext
	|-HashSet.Enumerator<Object>.MoveNext
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.MoveNext
	|-HashSet.Enumerator<IClippable>.MoveNext
	|-HashSet.Enumerator<MaskableGraphic>.MoveNext
	|-HashSet.Enumerator<Text>.MoveNext
	|
	|-RVA: 0x39DDB0 Offset: 0x39DEB1 VA: 0x39DDB0
	|-HashSet.Enumerator<CraftCategoryId>.MoveNext
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawnID>.MoveNext
	|-HashSet.Enumerator<ItemID>.MoveNext
	|-HashSet.Enumerator<RecipeId>.MoveNext
	|-HashSet.Enumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x39DC80 Offset: 0x39DD81 VA: 0x39DC80
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x39E010 Offset: 0x39E111 VA: 0x39E010
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x39E140 Offset: 0x39E241 VA: 0x39E140
	|-HashSet.Enumerator<Edge>.MoveNext
	|
	|-RVA: 0x39E280 Offset: 0x39E381 VA: 0x39E280
	|-HashSet.Enumerator<AsyncOperationHandle>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DEF0 Offset: 0x39DFF1 VA: 0x39DEF0
	|-HashSet.Enumerator<ActorController>.get_Current
	|-HashSet.Enumerator<EnvironmentSoundPointController>.get_Current
	|-HashSet.Enumerator<FieldHideItemSpawner>.get_Current
	|-HashSet.Enumerator<FieldItemSpawner>.get_Current
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawner>.get_Current
	|-HashSet.Enumerator<FieldRewardTreasureBoxSpawner>.get_Current
	|-HashSet.Enumerator<FieldUniqueTreasureBoxSpawner>.get_Current
	|-HashSet.Enumerator<MaterialChangeTime>.get_Current
	|-HashSet.Enumerator<ObjectChangeTime>.get_Current
	|-HashSet.Enumerator<RendererChangeTime>.get_Current
	|-HashSet.Enumerator<TextureChangeByFlag>.get_Current
	|-HashSet.Enumerator<VisibleChangeByFlag>.get_Current
	|-HashSet.Enumerator<BaseSpriteItemData>.get_Current
	|-HashSet.Enumerator<GimmickBase>.get_Current
	|-HashSet.Enumerator<MiningPoint>.get_Current
	|-HashSet.Enumerator<SEController>.get_Current
	|-HashSet.Enumerator<SeasonChangeObject>.get_Current
	|-HashSet.Enumerator<SeasonVisibleObject>.get_Current
	|-HashSet.Enumerator<Func<IEnumerator>>.get_Current
	|-HashSet.Enumerator<TeleportDragonRope>.get_Current
	|-HashSet.Enumerator<Collider>.get_Current
	|-HashSet.Enumerator<Material>.get_Current
	|-HashSet.Enumerator<Object>.get_Current
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.get_Current
	|-HashSet.Enumerator<IClippable>.get_Current
	|-HashSet.Enumerator<MaskableGraphic>.get_Current
	|-HashSet.Enumerator<Text>.get_Current
	|-HashSet.Enumerator<LabelScopeInfo>.get_Current
	|-HashSet.Enumerator<ParameterExpression>.get_Current
	|-HashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0x39DDC0 Offset: 0x39DEC1 VA: 0x39DDC0
	|-HashSet.Enumerator<CraftCategoryId>.get_Current
	|-HashSet.Enumerator<FieldRandomTreasureBoxSpawnID>.get_Current
	|-HashSet.Enumerator<ItemID>.get_Current
	|-HashSet.Enumerator<RecipeId>.get_Current
	|-HashSet.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x39E290 Offset: 0x39E391 VA: 0x39E290
	|-HashSet.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x39DC90 Offset: 0x39DD91 VA: 0x39DC90
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x39E020 Offset: 0x39E121 VA: 0x39E020
	|-HashSet.Enumerator<uint>.get_Current
	|
	|-RVA: 0x39E150 Offset: 0x39E251 VA: 0x39E150
	|-HashSet.Enumerator<Edge>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DCA0 Offset: 0x39DDA1 VA: 0x39DCA0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39DDD0 Offset: 0x39DED1 VA: 0x39DDD0
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39DF00 Offset: 0x39E001 VA: 0x39DF00
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E030 Offset: 0x39E131 VA: 0x39E030
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E160 Offset: 0x39E261 VA: 0x39E160
	|-HashSet.Enumerator<Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x39E2B0 Offset: 0x39E3B1 VA: 0x39E2B0
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39DCB0 Offset: 0x39DDB1 VA: 0x39DCB0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39DDE0 Offset: 0x39DEE1 VA: 0x39DDE0
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39DF10 Offset: 0x39E011 VA: 0x39DF10
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E040 Offset: 0x39E141 VA: 0x39E040
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E170 Offset: 0x39E271 VA: 0x39E170
	|-HashSet.Enumerator<Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x39E2C0 Offset: 0x39E3C1 VA: 0x39E2C0
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	*/
}

