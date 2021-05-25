public class UnityBlitResolver : IFormatterResolver // TypeDefIndex: 5207
{
	// Fields
	public static readonly UnityBlitResolver Instance; // 0x0

	// Methods

	// RVA: 0x14FE500 Offset: 0x14FE601 VA: 0x14FE500
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public IMessagePackFormatter<T> GetFormatter<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28075E0 Offset: 0x28076E1 VA: 0x28075E0
	|-UnityBlitResolver.GetFormatter<BitVector32Int>
	|
	|-RVA: 0x2807690 Offset: 0x2807791 VA: 0x2807690
	|-UnityBlitResolver.GetFormatter<EventCheckId>
	|
	|-RVA: 0x2807740 Offset: 0x2807841 VA: 0x2807740
	|-UnityBlitResolver.GetFormatter<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x28077F0 Offset: 0x28078F1 VA: 0x28077F0
	|-UnityBlitResolver.GetFormatter<FarmManager.RF4_CROP_STATE_INFO>
	|
	|-RVA: 0x28078A0 Offset: 0x28079A1 VA: 0x28078A0
	|-UnityBlitResolver.GetFormatter<FarmManager.RF4_MCROP_INFO>
	|
	|-RVA: 0x2807950 Offset: 0x2807A51 VA: 0x2807950
	|-UnityBlitResolver.GetFormatter<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x2807A00 Offset: 0x2807B01 VA: 0x2807A00
	|-UnityBlitResolver.GetFormatter<MonsterHutSaveData>
	|
	|-RVA: 0x2807AB0 Offset: 0x2807BB1 VA: 0x2807AB0
	|-UnityBlitResolver.GetFormatter<OrderLotterySaveParameter>
	|
	|-RVA: 0x2807B60 Offset: 0x2807C61 VA: 0x2807B60
	|-UnityBlitResolver.GetFormatter<OrderSaveData>
	|
	|-RVA: 0x2807C10 Offset: 0x2807D11 VA: 0x2807C10
	|-UnityBlitResolver.GetFormatter<OrderSaveParameter>
	|
	|-RVA: 0x2807CC0 Offset: 0x2807DC1 VA: 0x2807CC0
	|-UnityBlitResolver.GetFormatter<Parameter>
	|
	|-RVA: 0x2807D70 Offset: 0x2807E71 VA: 0x2807D70
	|-UnityBlitResolver.GetFormatter<bool>
	|
	|-RVA: 0x2807E20 Offset: 0x2807F21 VA: 0x2807E20
	|-UnityBlitResolver.GetFormatter<byte>
	|
	|-RVA: 0x2807ED0 Offset: 0x2807FD1 VA: 0x2807ED0
	|-UnityBlitResolver.GetFormatter<char>
	|
	|-RVA: 0x2807F80 Offset: 0x2808081 VA: 0x2807F80
	|-UnityBlitResolver.GetFormatter<DateTime>
	|
	|-RVA: 0x2808030 Offset: 0x2808131 VA: 0x2808030
	|-UnityBlitResolver.GetFormatter<double>
	|
	|-RVA: 0x28080E0 Offset: 0x28081E1 VA: 0x28080E0
	|-UnityBlitResolver.GetFormatter<short>
	|
	|-RVA: 0x2808190 Offset: 0x2808291 VA: 0x2808190
	|-UnityBlitResolver.GetFormatter<int>
	|
	|-RVA: 0x2808240 Offset: 0x2808341 VA: 0x2808240
	|-UnityBlitResolver.GetFormatter<Int32Enum>
	|
	|-RVA: 0x28082F0 Offset: 0x28083F1 VA: 0x28082F0
	|-UnityBlitResolver.GetFormatter<long>
	|
	|-RVA: 0x28083A0 Offset: 0x28084A1 VA: 0x28083A0
	|-UnityBlitResolver.GetFormatter<Memory<object>>
	|
	|-RVA: 0x2808450 Offset: 0x2808551 VA: 0x2808450
	|-UnityBlitResolver.GetFormatter<Nullable<Int32Enum>>
	|
	|-RVA: 0x2808500 Offset: 0x2808601 VA: 0x2808500
	|-UnityBlitResolver.GetFormatter<Nullable<Bounds>>
	|
	|-RVA: 0x28085B0 Offset: 0x28086B1 VA: 0x28085B0
	|-UnityBlitResolver.GetFormatter<Nullable<BoundsInt>>
	|
	|-RVA: 0x2808660 Offset: 0x2808761 VA: 0x2808660
	|-UnityBlitResolver.GetFormatter<Nullable<Color32>>
	|
	|-RVA: 0x2808710 Offset: 0x2808811 VA: 0x2808710
	|-UnityBlitResolver.GetFormatter<Nullable<Color>>
	|
	|-RVA: 0x28087C0 Offset: 0x28088C1 VA: 0x28087C0
	|-UnityBlitResolver.GetFormatter<Nullable<GradientAlphaKey>>
	|
	|-RVA: 0x2808870 Offset: 0x2808971 VA: 0x2808870
	|-UnityBlitResolver.GetFormatter<Nullable<GradientColorKey>>
	|
	|-RVA: 0x2808920 Offset: 0x2808A21 VA: 0x2808920
	|-UnityBlitResolver.GetFormatter<Nullable<Keyframe>>
	|
	|-RVA: 0x28089D0 Offset: 0x2808AD1 VA: 0x28089D0
	|-UnityBlitResolver.GetFormatter<Nullable<LayerMask>>
	|
	|-RVA: 0x2808A80 Offset: 0x2808B81 VA: 0x2808A80
	|-UnityBlitResolver.GetFormatter<Nullable<Matrix4x4>>
	|
	|-RVA: 0x2808B30 Offset: 0x2808C31 VA: 0x2808B30
	|-UnityBlitResolver.GetFormatter<Nullable<Quaternion>>
	|
	|-RVA: 0x2808BE0 Offset: 0x2808CE1 VA: 0x2808BE0
	|-UnityBlitResolver.GetFormatter<Nullable<RangeInt>>
	|
	|-RVA: 0x2808C90 Offset: 0x2808D91 VA: 0x2808C90
	|-UnityBlitResolver.GetFormatter<Nullable<Rect>>
	|
	|-RVA: 0x2808D40 Offset: 0x2808E41 VA: 0x2808D40
	|-UnityBlitResolver.GetFormatter<Nullable<RectInt>>
	|
	|-RVA: 0x2808DF0 Offset: 0x2808EF1 VA: 0x2808DF0
	|-UnityBlitResolver.GetFormatter<Nullable<Vector2>>
	|
	|-RVA: 0x2808EA0 Offset: 0x2808FA1 VA: 0x2808EA0
	|-UnityBlitResolver.GetFormatter<Nullable<Vector2Int>>
	|
	|-RVA: 0x2808F50 Offset: 0x2809051 VA: 0x2808F50
	|-UnityBlitResolver.GetFormatter<Nullable<Vector3>>
	|
	|-RVA: 0x2809000 Offset: 0x2809101 VA: 0x2809000
	|-UnityBlitResolver.GetFormatter<Nullable<Vector3Int>>
	|
	|-RVA: 0x28090B0 Offset: 0x28091B1 VA: 0x28090B0
	|-UnityBlitResolver.GetFormatter<Nullable<Vector4>>
	|
	|-RVA: 0x2809160 Offset: 0x2809261 VA: 0x2809160
	|-UnityBlitResolver.GetFormatter<object>
	|
	|-RVA: 0x2809210 Offset: 0x2809311 VA: 0x2809210
	|-UnityBlitResolver.GetFormatter<ReadOnlyMemory<object>>
	|
	|-RVA: 0x28092C0 Offset: 0x28093C1 VA: 0x28092C0
	|-UnityBlitResolver.GetFormatter<sbyte>
	|
	|-RVA: 0x2809370 Offset: 0x2809471 VA: 0x2809370
	|-UnityBlitResolver.GetFormatter<float>
	|
	|-RVA: 0x2809420 Offset: 0x2809521 VA: 0x2809420
	|-UnityBlitResolver.GetFormatter<ushort>
	|
	|-RVA: 0x28094D0 Offset: 0x28095D1 VA: 0x28094D0
	|-UnityBlitResolver.GetFormatter<uint>
	|
	|-RVA: 0x2809580 Offset: 0x2809681 VA: 0x2809580
	|-UnityBlitResolver.GetFormatter<ulong>
	|
	|-RVA: 0x2809630 Offset: 0x2809731 VA: 0x2809630
	|-UnityBlitResolver.GetFormatter<Bounds>
	|
	|-RVA: 0x28096E0 Offset: 0x28097E1 VA: 0x28096E0
	|-UnityBlitResolver.GetFormatter<BoundsInt>
	|
	|-RVA: 0x2809790 Offset: 0x2809891 VA: 0x2809790
	|-UnityBlitResolver.GetFormatter<Color32>
	|
	|-RVA: 0x2809840 Offset: 0x2809941 VA: 0x2809840
	|-UnityBlitResolver.GetFormatter<Color>
	|
	|-RVA: 0x28098F0 Offset: 0x28099F1 VA: 0x28098F0
	|-UnityBlitResolver.GetFormatter<GradientAlphaKey>
	|
	|-RVA: 0x28099A0 Offset: 0x2809AA1 VA: 0x28099A0
	|-UnityBlitResolver.GetFormatter<GradientColorKey>
	|
	|-RVA: 0x2809A50 Offset: 0x2809B51 VA: 0x2809A50
	|-UnityBlitResolver.GetFormatter<Keyframe>
	|
	|-RVA: 0x2809B00 Offset: 0x2809C01 VA: 0x2809B00
	|-UnityBlitResolver.GetFormatter<LayerMask>
	|
	|-RVA: 0x2809BB0 Offset: 0x2809CB1 VA: 0x2809BB0
	|-UnityBlitResolver.GetFormatter<Matrix4x4>
	|
	|-RVA: 0x2809C60 Offset: 0x2809D61 VA: 0x2809C60
	|-UnityBlitResolver.GetFormatter<Quaternion>
	|
	|-RVA: 0x2809D10 Offset: 0x2809E11 VA: 0x2809D10
	|-UnityBlitResolver.GetFormatter<RangeInt>
	|
	|-RVA: 0x2809DC0 Offset: 0x2809EC1 VA: 0x2809DC0
	|-UnityBlitResolver.GetFormatter<Rect>
	|
	|-RVA: 0x2809E70 Offset: 0x2809F71 VA: 0x2809E70
	|-UnityBlitResolver.GetFormatter<RectInt>
	|
	|-RVA: 0x2809F20 Offset: 0x280A021 VA: 0x2809F20
	|-UnityBlitResolver.GetFormatter<Vector2>
	|
	|-RVA: 0x2809FD0 Offset: 0x280A0D1 VA: 0x2809FD0
	|-UnityBlitResolver.GetFormatter<Vector2Int>
	|
	|-RVA: 0x280A080 Offset: 0x280A181 VA: 0x280A080
	|-UnityBlitResolver.GetFormatter<Vector3>
	|
	|-RVA: 0x280A130 Offset: 0x280A231 VA: 0x280A130
	|-UnityBlitResolver.GetFormatter<Vector3Int>
	|
	|-RVA: 0x280A1E0 Offset: 0x280A2E1 VA: 0x280A1E0
	|-UnityBlitResolver.GetFormatter<Vector4>
	*/

	// RVA: 0x14FE510 Offset: 0x14FE611 VA: 0x14FE510
	private static void .cctor() { }
}

