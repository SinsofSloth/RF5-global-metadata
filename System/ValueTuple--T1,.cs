[Serializable]
public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple // TypeDefIndex: 113
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38D060 Offset: 0x38D161 VA: 0x38D060
	|-ValueTuple<CharacterBase, float>..ctor
	|-ValueTuple<object, float>..ctor
	|
	|-RVA: 0x38C770 Offset: 0x38C871 VA: 0x38C770
	|-ValueTuple<ActorID, int>..ctor
	|-ValueTuple<Season, int>..ctor
	|-ValueTuple<Int32Enum, int>..ctor
	|
	|-RVA: 0x38C950 Offset: 0x38CA51 VA: 0x38C950
	|-ValueTuple<EventSelectGroupType, List<string>>..ctor
	|-ValueTuple<SoundID, EnvironmentSoundController>..ctor
	|-ValueTuple<Int32Enum, object>..ctor
	|
	|-RVA: 0x38CD10 Offset: 0x38CE11 VA: 0x38CD10
	|-ValueTuple<ItemData, StorageType>..ctor
	|-ValueTuple<object, Int32Enum>..ctor
	|
	|-RVA: 0x38CAB0 Offset: 0x38CBB1 VA: 0x38CAB0
	|-ValueTuple<ItemData, int>..ctor
	|-ValueTuple<object, int>..ctor
	|
	|-RVA: 0x38CE90 Offset: 0x38CF91 VA: 0x38CE90
	|-ValueTuple<MonsterParamDataTable, MonsterParamDataTable>..ctor
	|-ValueTuple<SEController, List<EnvironmentSoundArea>>..ctor
	|-ValueTuple<object, object>..ctor
	|-ValueTuple<string, Func<string>>..ctor
	|
	|-RVA: 0x3841A0 Offset: 0x3842A1 VA: 0x3841A0
	|-ValueTuple<Parameter, EquipSubAttributeCollection>..ctor
	|-ValueTuple<Parameter, object>..ctor
	|
	|-RVA: 0x38C0E0 Offset: 0x38C1E1 VA: 0x38C0E0
	|-ValueTuple<bool, ItemData>..ctor
	|-ValueTuple<bool, ItemData[]>..ctor
	|-ValueTuple<bool, bool[]>..ctor
	|-ValueTuple<bool, object>..ctor
	|
	|-RVA: 0x38BEF0 Offset: 0x38BFF1 VA: 0x38BEF0
	|-ValueTuple<bool, ItemID>..ctor
	|-ValueTuple<bool, Int32Enum>..ctor
	|
	|-RVA: 0x38C330 Offset: 0x38C431 VA: 0x38C330
	|-ValueTuple<int, bool>..ctor
	|
	|-RVA: 0x38C550 Offset: 0x38C651 VA: 0x38C550
	|-ValueTuple<int, int>..ctor
	|
	|-RVA: 0x38D2D0 Offset: 0x38D3D1 VA: 0x38D2D0
	|-ValueTuple<float, ActionCommandBase>..ctor
	|-ValueTuple<float, MagicID[]>..ctor
	|-ValueTuple<float, object>..ctor
	|
	|-RVA: 0x38D510 Offset: 0x38D611 VA: 0x38D510
	|-ValueTuple<float, float>..ctor
	|
	|-RVA: 0x38D730 Offset: 0x38D831 VA: 0x38D730
	|-ValueTuple<Vector3, Quaternion>..ctor
	|
	|-RVA: 0x38D9C0 Offset: 0x38DAC1 VA: 0x38D9C0
	|-ValueTuple<Vector3, Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3841E0 Offset: 0x3842E1 VA: 0x3841E0
	|-ValueTuple<Parameter, object>.Equals
	|
	|-RVA: 0x38BF00 Offset: 0x38C001 VA: 0x38BF00
	|-ValueTuple<bool, Int32Enum>.Equals
	|
	|-RVA: 0x38C100 Offset: 0x38C201 VA: 0x38C100
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x38C340 Offset: 0x38C441 VA: 0x38C340
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x38C560 Offset: 0x38C661 VA: 0x38C560
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x38C780 Offset: 0x38C881 VA: 0x38C780
	|-ValueTuple<Int32Enum, int>.Equals
	|
	|-RVA: 0x38C960 Offset: 0x38CA61 VA: 0x38C960
	|-ValueTuple<Int32Enum, object>.Equals
	|
	|-RVA: 0x38CAE0 Offset: 0x38CBE1 VA: 0x38CAE0
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x38CD40 Offset: 0x38CE41 VA: 0x38CD40
	|-ValueTuple<object, Int32Enum>.Equals
	|
	|-RVA: 0x38CED0 Offset: 0x38CFD1 VA: 0x38CED0
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x38D0A0 Offset: 0x38D1A1 VA: 0x38D0A0
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x38D2E0 Offset: 0x38D3E1 VA: 0x38D2E0
	|-ValueTuple<float, object>.Equals
	|
	|-RVA: 0x38D520 Offset: 0x38D621 VA: 0x38D520
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x38D750 Offset: 0x38D851 VA: 0x38D750
	|-ValueTuple<Vector3, Quaternion>.Equals
	|
	|-RVA: 0x38D9E0 Offset: 0x38DAE1 VA: 0x38D9E0
	|-ValueTuple<Vector3, Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3841F0 Offset: 0x3842F1 VA: 0x3841F0
	|-ValueTuple<Parameter, object>.Equals
	|
	|-RVA: 0x38BF10 Offset: 0x38C011 VA: 0x38BF10
	|-ValueTuple<bool, Int32Enum>.Equals
	|
	|-RVA: 0x38C110 Offset: 0x38C211 VA: 0x38C110
	|-ValueTuple<bool, object>.Equals
	|
	|-RVA: 0x38C350 Offset: 0x38C451 VA: 0x38C350
	|-ValueTuple<int, bool>.Equals
	|
	|-RVA: 0x38C570 Offset: 0x38C671 VA: 0x38C570
	|-ValueTuple<int, int>.Equals
	|
	|-RVA: 0x38C790 Offset: 0x38C891 VA: 0x38C790
	|-ValueTuple<Int32Enum, int>.Equals
	|
	|-RVA: 0x38C970 Offset: 0x38CA71 VA: 0x38C970
	|-ValueTuple<Int32Enum, object>.Equals
	|
	|-RVA: 0x38CAF0 Offset: 0x38CBF1 VA: 0x38CAF0
	|-ValueTuple<object, int>.Equals
	|
	|-RVA: 0x38CD50 Offset: 0x38CE51 VA: 0x38CD50
	|-ValueTuple<object, Int32Enum>.Equals
	|
	|-RVA: 0x38CEE0 Offset: 0x38CFE1 VA: 0x38CEE0
	|-ValueTuple<object, object>.Equals
	|
	|-RVA: 0x38D0B0 Offset: 0x38D1B1 VA: 0x38D0B0
	|-ValueTuple<object, float>.Equals
	|
	|-RVA: 0x38D2F0 Offset: 0x38D3F1 VA: 0x38D2F0
	|-ValueTuple<float, object>.Equals
	|
	|-RVA: 0x38D530 Offset: 0x38D631 VA: 0x38D530
	|-ValueTuple<float, float>.Equals
	|
	|-RVA: 0x38D760 Offset: 0x38D861 VA: 0x38D760
	|-ValueTuple<Vector3, Quaternion>.Equals
	|
	|-RVA: 0x38D9F0 Offset: 0x38DAF1 VA: 0x38D9F0
	|-ValueTuple<Vector3, Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384240 Offset: 0x384341 VA: 0x384240
	|-ValueTuple<Parameter, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38BF20 Offset: 0x38C021 VA: 0x38BF20
	|-ValueTuple<bool, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38C120 Offset: 0x38C221 VA: 0x38C120
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38C360 Offset: 0x38C461 VA: 0x38C360
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38C580 Offset: 0x38C681 VA: 0x38C580
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38C7A0 Offset: 0x38C8A1 VA: 0x38C7A0
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38C980 Offset: 0x38CA81 VA: 0x38C980
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38CB00 Offset: 0x38CC01 VA: 0x38CB00
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38CD60 Offset: 0x38CE61 VA: 0x38CD60
	|-ValueTuple<object, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38CEF0 Offset: 0x38CFF1 VA: 0x38CEF0
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38D0C0 Offset: 0x38D1C1 VA: 0x38D0C0
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38D300 Offset: 0x38D401 VA: 0x38D300
	|-ValueTuple<float, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38D540 Offset: 0x38D641 VA: 0x38D540
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38D7A0 Offset: 0x38D8A1 VA: 0x38D7A0
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38DA30 Offset: 0x38DB31 VA: 0x38DA30
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384250 Offset: 0x384351 VA: 0x384250
	|-ValueTuple<Parameter, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38BF30 Offset: 0x38C031 VA: 0x38BF30
	|-ValueTuple<bool, Int32Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x38C130 Offset: 0x38C231 VA: 0x38C130
	|-ValueTuple<bool, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38C370 Offset: 0x38C471 VA: 0x38C370
	|-ValueTuple<int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x38C590 Offset: 0x38C691 VA: 0x38C590
	|-ValueTuple<int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x38C7B0 Offset: 0x38C8B1 VA: 0x38C7B0
	|-ValueTuple<Int32Enum, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x38C990 Offset: 0x38CA91 VA: 0x38C990
	|-ValueTuple<Int32Enum, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38CB10 Offset: 0x38CC11 VA: 0x38CB10
	|-ValueTuple<object, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x38CD70 Offset: 0x38CE71 VA: 0x38CD70
	|-ValueTuple<object, Int32Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x38CF00 Offset: 0x38D001 VA: 0x38CF00
	|-ValueTuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38D0D0 Offset: 0x38D1D1 VA: 0x38D0D0
	|-ValueTuple<object, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x38D310 Offset: 0x38D411 VA: 0x38D310
	|-ValueTuple<float, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38D550 Offset: 0x38D651 VA: 0x38D550
	|-ValueTuple<float, float>.System.IComparable.CompareTo
	|
	|-RVA: 0x38D7B0 Offset: 0x38D8B1 VA: 0x38D7B0
	|-ValueTuple<Vector3, Quaternion>.System.IComparable.CompareTo
	|
	|-RVA: 0x38DA40 Offset: 0x38DB41 VA: 0x38DA40
	|-ValueTuple<Vector3, Vector3>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384260 Offset: 0x384361 VA: 0x384260
	|-ValueTuple<Parameter, object>.CompareTo
	|
	|-RVA: 0x38BF40 Offset: 0x38C041 VA: 0x38BF40
	|-ValueTuple<bool, Int32Enum>.CompareTo
	|
	|-RVA: 0x38C140 Offset: 0x38C241 VA: 0x38C140
	|-ValueTuple<bool, object>.CompareTo
	|
	|-RVA: 0x38C380 Offset: 0x38C481 VA: 0x38C380
	|-ValueTuple<int, bool>.CompareTo
	|
	|-RVA: 0x38C5A0 Offset: 0x38C6A1 VA: 0x38C5A0
	|-ValueTuple<int, int>.CompareTo
	|
	|-RVA: 0x38C7C0 Offset: 0x38C8C1 VA: 0x38C7C0
	|-ValueTuple<Int32Enum, int>.CompareTo
	|
	|-RVA: 0x38C9A0 Offset: 0x38CAA1 VA: 0x38C9A0
	|-ValueTuple<Int32Enum, object>.CompareTo
	|
	|-RVA: 0x38CB20 Offset: 0x38CC21 VA: 0x38CB20
	|-ValueTuple<object, int>.CompareTo
	|
	|-RVA: 0x38CD80 Offset: 0x38CE81 VA: 0x38CD80
	|-ValueTuple<object, Int32Enum>.CompareTo
	|
	|-RVA: 0x38CF10 Offset: 0x38D011 VA: 0x38CF10
	|-ValueTuple<object, object>.CompareTo
	|
	|-RVA: 0x38D0E0 Offset: 0x38D1E1 VA: 0x38D0E0
	|-ValueTuple<object, float>.CompareTo
	|
	|-RVA: 0x38D320 Offset: 0x38D421 VA: 0x38D320
	|-ValueTuple<float, object>.CompareTo
	|
	|-RVA: 0x38D560 Offset: 0x38D661 VA: 0x38D560
	|-ValueTuple<float, float>.CompareTo
	|
	|-RVA: 0x38D7C0 Offset: 0x38D8C1 VA: 0x38D7C0
	|-ValueTuple<Vector3, Quaternion>.CompareTo
	|
	|-RVA: 0x38DA50 Offset: 0x38DB51 VA: 0x38DA50
	|-ValueTuple<Vector3, Vector3>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3842B0 Offset: 0x3843B1 VA: 0x3842B0
	|-ValueTuple<Parameter, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38BF50 Offset: 0x38C051 VA: 0x38BF50
	|-ValueTuple<bool, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38C150 Offset: 0x38C251 VA: 0x38C150
	|-ValueTuple<bool, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38C390 Offset: 0x38C491 VA: 0x38C390
	|-ValueTuple<int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38C5B0 Offset: 0x38C6B1 VA: 0x38C5B0
	|-ValueTuple<int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38C7D0 Offset: 0x38C8D1 VA: 0x38C7D0
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38C9B0 Offset: 0x38CAB1 VA: 0x38C9B0
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38CB30 Offset: 0x38CC31 VA: 0x38CB30
	|-ValueTuple<object, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38CD90 Offset: 0x38CE91 VA: 0x38CD90
	|-ValueTuple<object, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38CF20 Offset: 0x38D021 VA: 0x38CF20
	|-ValueTuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38D0F0 Offset: 0x38D1F1 VA: 0x38D0F0
	|-ValueTuple<object, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38D330 Offset: 0x38D431 VA: 0x38D330
	|-ValueTuple<float, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38D570 Offset: 0x38D671 VA: 0x38D570
	|-ValueTuple<float, float>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38D800 Offset: 0x38D901 VA: 0x38D800
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38DA90 Offset: 0x38DB91 VA: 0x38DA90
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3842C0 Offset: 0x3843C1 VA: 0x3842C0
	|-ValueTuple<Parameter, object>.GetHashCode
	|
	|-RVA: 0x38BF60 Offset: 0x38C061 VA: 0x38BF60
	|-ValueTuple<bool, Int32Enum>.GetHashCode
	|
	|-RVA: 0x38C160 Offset: 0x38C261 VA: 0x38C160
	|-ValueTuple<bool, object>.GetHashCode
	|
	|-RVA: 0x38C3A0 Offset: 0x38C4A1 VA: 0x38C3A0
	|-ValueTuple<int, bool>.GetHashCode
	|
	|-RVA: 0x38C5C0 Offset: 0x38C6C1 VA: 0x38C5C0
	|-ValueTuple<int, int>.GetHashCode
	|
	|-RVA: 0x38C7E0 Offset: 0x38C8E1 VA: 0x38C7E0
	|-ValueTuple<Int32Enum, int>.GetHashCode
	|
	|-RVA: 0x38C9C0 Offset: 0x38CAC1 VA: 0x38C9C0
	|-ValueTuple<Int32Enum, object>.GetHashCode
	|
	|-RVA: 0x38CB40 Offset: 0x38CC41 VA: 0x38CB40
	|-ValueTuple<object, int>.GetHashCode
	|
	|-RVA: 0x38CDA0 Offset: 0x38CEA1 VA: 0x38CDA0
	|-ValueTuple<object, Int32Enum>.GetHashCode
	|
	|-RVA: 0x38CF30 Offset: 0x38D031 VA: 0x38CF30
	|-ValueTuple<object, object>.GetHashCode
	|
	|-RVA: 0x38D100 Offset: 0x38D201 VA: 0x38D100
	|-ValueTuple<object, float>.GetHashCode
	|
	|-RVA: 0x38D340 Offset: 0x38D441 VA: 0x38D340
	|-ValueTuple<float, object>.GetHashCode
	|
	|-RVA: 0x38D580 Offset: 0x38D681 VA: 0x38D580
	|-ValueTuple<float, float>.GetHashCode
	|
	|-RVA: 0x38D810 Offset: 0x38D911 VA: 0x38D810
	|-ValueTuple<Vector3, Quaternion>.GetHashCode
	|
	|-RVA: 0x38DAA0 Offset: 0x38DBA1 VA: 0x38DAA0
	|-ValueTuple<Vector3, Vector3>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3842D0 Offset: 0x3843D1 VA: 0x3842D0
	|-ValueTuple<Parameter, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C000 Offset: 0x38C101 VA: 0x38C000
	|-ValueTuple<bool, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C1C0 Offset: 0x38C2C1 VA: 0x38C1C0
	|-ValueTuple<bool, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C3F0 Offset: 0x38C4F1 VA: 0x38C3F0
	|-ValueTuple<int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C610 Offset: 0x38C711 VA: 0x38C610
	|-ValueTuple<int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C870 Offset: 0x38C971 VA: 0x38C870
	|-ValueTuple<Int32Enum, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38C9D0 Offset: 0x38CAD1 VA: 0x38C9D0
	|-ValueTuple<Int32Enum, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38CBA0 Offset: 0x38CCA1 VA: 0x38CBA0
	|-ValueTuple<object, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38CDB0 Offset: 0x38CEB1 VA: 0x38CDB0
	|-ValueTuple<object, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38CFA0 Offset: 0x38D0A1 VA: 0x38CFA0
	|-ValueTuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38D160 Offset: 0x38D261 VA: 0x38D160
	|-ValueTuple<object, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38D3A0 Offset: 0x38D4A1 VA: 0x38D3A0
	|-ValueTuple<float, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38D5D0 Offset: 0x38D6D1 VA: 0x38D5D0
	|-ValueTuple<float, float>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38D860 Offset: 0x38D961 VA: 0x38D860
	|-ValueTuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38DAF0 Offset: 0x38DBF1 VA: 0x38DAF0
	|-ValueTuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384320 Offset: 0x384421 VA: 0x384320
	|-ValueTuple<Parameter, object>.GetHashCodeCore
	|
	|-RVA: 0x38C050 Offset: 0x38C151 VA: 0x38C050
	|-ValueTuple<bool, Int32Enum>.GetHashCodeCore
	|
	|-RVA: 0x38C210 Offset: 0x38C311 VA: 0x38C210
	|-ValueTuple<bool, object>.GetHashCodeCore
	|
	|-RVA: 0x38C440 Offset: 0x38C541 VA: 0x38C440
	|-ValueTuple<int, bool>.GetHashCodeCore
	|
	|-RVA: 0x38C660 Offset: 0x38C761 VA: 0x38C660
	|-ValueTuple<int, int>.GetHashCodeCore
	|
	|-RVA: 0x38C8C0 Offset: 0x38C9C1 VA: 0x38C8C0
	|-ValueTuple<Int32Enum, int>.GetHashCodeCore
	|
	|-RVA: 0x38CA20 Offset: 0x38CB21 VA: 0x38CA20
	|-ValueTuple<Int32Enum, object>.GetHashCodeCore
	|
	|-RVA: 0x38CBF0 Offset: 0x38CCF1 VA: 0x38CBF0
	|-ValueTuple<object, int>.GetHashCodeCore
	|
	|-RVA: 0x38CE00 Offset: 0x38CF01 VA: 0x38CE00
	|-ValueTuple<object, Int32Enum>.GetHashCodeCore
	|
	|-RVA: 0x38CFE0 Offset: 0x38D0E1 VA: 0x38CFE0
	|-ValueTuple<object, object>.GetHashCodeCore
	|
	|-RVA: 0x38D1B0 Offset: 0x38D2B1 VA: 0x38D1B0
	|-ValueTuple<object, float>.GetHashCodeCore
	|
	|-RVA: 0x38D3F0 Offset: 0x38D4F1 VA: 0x38D3F0
	|-ValueTuple<float, object>.GetHashCodeCore
	|
	|-RVA: 0x38D620 Offset: 0x38D721 VA: 0x38D620
	|-ValueTuple<float, float>.GetHashCodeCore
	|
	|-RVA: 0x38D8B0 Offset: 0x38D9B1 VA: 0x38D8B0
	|-ValueTuple<Vector3, Quaternion>.GetHashCodeCore
	|
	|-RVA: 0x38DB40 Offset: 0x38DC41 VA: 0x38DB40
	|-ValueTuple<Vector3, Vector3>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384330 Offset: 0x384431 VA: 0x384330
	|-ValueTuple<Parameter, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38C060 Offset: 0x38C161 VA: 0x38C060
	|-ValueTuple<bool, Int32Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38C220 Offset: 0x38C321 VA: 0x38C220
	|-ValueTuple<bool, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38C450 Offset: 0x38C551 VA: 0x38C450
	|-ValueTuple<int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38C670 Offset: 0x38C771 VA: 0x38C670
	|-ValueTuple<int, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38C8D0 Offset: 0x38C9D1 VA: 0x38C8D0
	|-ValueTuple<Int32Enum, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38CA30 Offset: 0x38CB31 VA: 0x38CA30
	|-ValueTuple<Int32Enum, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38CC00 Offset: 0x38CD01 VA: 0x38CC00
	|-ValueTuple<object, int>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38CE10 Offset: 0x38CF11 VA: 0x38CE10
	|-ValueTuple<object, Int32Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38CFF0 Offset: 0x38D0F1 VA: 0x38CFF0
	|-ValueTuple<object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38D1C0 Offset: 0x38D2C1 VA: 0x38D1C0
	|-ValueTuple<object, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38D400 Offset: 0x38D501 VA: 0x38D400
	|-ValueTuple<float, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38D630 Offset: 0x38D731 VA: 0x38D630
	|-ValueTuple<float, float>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38D8C0 Offset: 0x38D9C1 VA: 0x38D8C0
	|-ValueTuple<Vector3, Quaternion>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38DB50 Offset: 0x38DC51 VA: 0x38DB50
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384380 Offset: 0x384481 VA: 0x384380
	|-ValueTuple<Parameter, object>.ToString
	|
	|-RVA: 0x38C0B0 Offset: 0x38C1B1 VA: 0x38C0B0
	|-ValueTuple<bool, Int32Enum>.ToString
	|
	|-RVA: 0x38C270 Offset: 0x38C371 VA: 0x38C270
	|-ValueTuple<bool, object>.ToString
	|
	|-RVA: 0x38C4A0 Offset: 0x38C5A1 VA: 0x38C4A0
	|-ValueTuple<int, bool>.ToString
	|
	|-RVA: 0x38C6C0 Offset: 0x38C7C1 VA: 0x38C6C0
	|-ValueTuple<int, int>.ToString
	|
	|-RVA: 0x38C920 Offset: 0x38CA21 VA: 0x38C920
	|-ValueTuple<Int32Enum, int>.ToString
	|
	|-RVA: 0x38CA80 Offset: 0x38CB81 VA: 0x38CA80
	|-ValueTuple<Int32Enum, object>.ToString
	|
	|-RVA: 0x38CC50 Offset: 0x38CD51 VA: 0x38CC50
	|-ValueTuple<object, int>.ToString
	|
	|-RVA: 0x38CE60 Offset: 0x38CF61 VA: 0x38CE60
	|-ValueTuple<object, Int32Enum>.ToString
	|
	|-RVA: 0x38D030 Offset: 0x38D131 VA: 0x38D030
	|-ValueTuple<object, object>.ToString
	|
	|-RVA: 0x38D210 Offset: 0x38D311 VA: 0x38D210
	|-ValueTuple<object, float>.ToString
	|
	|-RVA: 0x38D450 Offset: 0x38D551 VA: 0x38D450
	|-ValueTuple<float, object>.ToString
	|
	|-RVA: 0x38D680 Offset: 0x38D781 VA: 0x38D680
	|-ValueTuple<float, float>.ToString
	|
	|-RVA: 0x38D910 Offset: 0x38DA11 VA: 0x38D910
	|-ValueTuple<Vector3, Quaternion>.ToString
	|
	|-RVA: 0x38DBA0 Offset: 0x38DCA1 VA: 0x38DBA0
	|-ValueTuple<Vector3, Vector3>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384390 Offset: 0x384491 VA: 0x384390
	|-ValueTuple<Parameter, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38C0C0 Offset: 0x38C1C1 VA: 0x38C0C0
	|-ValueTuple<bool, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38C280 Offset: 0x38C381 VA: 0x38C280
	|-ValueTuple<bool, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38C4B0 Offset: 0x38C5B1 VA: 0x38C4B0
	|-ValueTuple<int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38C6D0 Offset: 0x38C7D1 VA: 0x38C6D0
	|-ValueTuple<int, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38C930 Offset: 0x38CA31 VA: 0x38C930
	|-ValueTuple<Int32Enum, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38CA90 Offset: 0x38CB91 VA: 0x38CA90
	|-ValueTuple<Int32Enum, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38CC60 Offset: 0x38CD61 VA: 0x38CC60
	|-ValueTuple<object, int>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38CE70 Offset: 0x38CF71 VA: 0x38CE70
	|-ValueTuple<object, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38D040 Offset: 0x38D141 VA: 0x38D040
	|-ValueTuple<object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38D220 Offset: 0x38D321 VA: 0x38D220
	|-ValueTuple<object, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38D460 Offset: 0x38D561 VA: 0x38D460
	|-ValueTuple<float, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38D690 Offset: 0x38D791 VA: 0x38D690
	|-ValueTuple<float, float>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38D920 Offset: 0x38DA21 VA: 0x38D920
	|-ValueTuple<Vector3, Quaternion>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38DBB0 Offset: 0x38DCB1 VA: 0x38DBB0
	|-ValueTuple<Vector3, Vector3>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3843A0 Offset: 0x3844A1 VA: 0x3843A0
	|-ValueTuple<Parameter, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38C0D0 Offset: 0x38C1D1 VA: 0x38C0D0
	|-ValueTuple<bool, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38C320 Offset: 0x38C421 VA: 0x38C320
	|-ValueTuple<bool, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38C540 Offset: 0x38C641 VA: 0x38C540
	|-ValueTuple<int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38C760 Offset: 0x38C861 VA: 0x38C760
	|-ValueTuple<int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38C940 Offset: 0x38CA41 VA: 0x38C940
	|-ValueTuple<Int32Enum, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38CAA0 Offset: 0x38CBA1 VA: 0x38CAA0
	|-ValueTuple<Int32Enum, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38CD00 Offset: 0x38CE01 VA: 0x38CD00
	|-ValueTuple<object, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38CE80 Offset: 0x38CF81 VA: 0x38CE80
	|-ValueTuple<object, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38D050 Offset: 0x38D151 VA: 0x38D050
	|-ValueTuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38D2C0 Offset: 0x38D3C1 VA: 0x38D2C0
	|-ValueTuple<object, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38D500 Offset: 0x38D601 VA: 0x38D500
	|-ValueTuple<float, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38D720 Offset: 0x38D821 VA: 0x38D720
	|-ValueTuple<float, float>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38D9B0 Offset: 0x38DAB1 VA: 0x38D9B0
	|-ValueTuple<Vector3, Quaternion>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38DC40 Offset: 0x38DD41 VA: 0x38DC40
	|-ValueTuple<Vector3, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple // TypeDefIndex: 114
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DC50 Offset: 0x38DD51 VA: 0x38DC50
	|-ValueTuple<CharID, VariationNo, HairType>..ctor
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x38DDB0 Offset: 0x38DEB1 VA: 0x38DDB0
	|-ValueTuple<object, object, object>..ctor
	|
	|-RVA: 0x38DF90 Offset: 0x38E091 VA: 0x38DF90
	|-ValueTuple<object, object, Vector3>..ctor
	|-ValueTuple<Collider, FocusInterface, Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DC60 Offset: 0x38DD61 VA: 0x38DC60
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.Equals
	|
	|-RVA: 0x38DE00 Offset: 0x38DF01 VA: 0x38DE00
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x38DFF0 Offset: 0x38E0F1 VA: 0x38DFF0
	|-ValueTuple<object, object, Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DC70 Offset: 0x38DD71 VA: 0x38DC70
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.Equals
	|
	|-RVA: 0x38DE10 Offset: 0x38DF11 VA: 0x38DE10
	|-ValueTuple<object, object, object>.Equals
	|
	|-RVA: 0x38E000 Offset: 0x38E101 VA: 0x38E000
	|-ValueTuple<object, object, Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DC80 Offset: 0x38DD81 VA: 0x38DC80
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38DE50 Offset: 0x38DF51 VA: 0x38DE50
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38E040 Offset: 0x38E141 VA: 0x38E040
	|-ValueTuple<object, object, Vector3>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DC90 Offset: 0x38DD91 VA: 0x38DC90
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.IComparable.CompareTo
	|
	|-RVA: 0x38DE60 Offset: 0x38DF61 VA: 0x38DE60
	|-ValueTuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38E050 Offset: 0x38E151 VA: 0x38E050
	|-ValueTuple<object, object, Vector3>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DCA0 Offset: 0x38DDA1 VA: 0x38DCA0
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.CompareTo
	|
	|-RVA: 0x38DE70 Offset: 0x38DF71 VA: 0x38DE70
	|-ValueTuple<object, object, object>.CompareTo
	|
	|-RVA: 0x38E060 Offset: 0x38E161 VA: 0x38E060
	|-ValueTuple<object, object, Vector3>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DCB0 Offset: 0x38DDB1 VA: 0x38DCB0
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38DEB0 Offset: 0x38DFB1 VA: 0x38DEB0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38E0A0 Offset: 0x38E1A1 VA: 0x38E0A0
	|-ValueTuple<object, object, Vector3>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DCC0 Offset: 0x38DDC1 VA: 0x38DCC0
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.GetHashCode
	|
	|-RVA: 0x38DEC0 Offset: 0x38DFC1 VA: 0x38DEC0
	|-ValueTuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x38E0B0 Offset: 0x38E1B1 VA: 0x38E0B0
	|-ValueTuple<object, object, Vector3>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DCD0 Offset: 0x38DDD1 VA: 0x38DCD0
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38DED0 Offset: 0x38DFD1 VA: 0x38DED0
	|-ValueTuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38E0C0 Offset: 0x38E1C1 VA: 0x38E0C0
	|-ValueTuple<object, object, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD20 Offset: 0x38DE21 VA: 0x38DD20
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.GetHashCodeCore
	|
	|-RVA: 0x38DF10 Offset: 0x38E011 VA: 0x38DF10
	|-ValueTuple<object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x38E110 Offset: 0x38E211 VA: 0x38E110
	|-ValueTuple<object, object, Vector3>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD30 Offset: 0x38DE31 VA: 0x38DD30
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38DF20 Offset: 0x38E021 VA: 0x38DF20
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38E120 Offset: 0x38E221 VA: 0x38E120
	|-ValueTuple<object, object, Vector3>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD80 Offset: 0x38DE81 VA: 0x38DD80
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.ToString
	|
	|-RVA: 0x38DF60 Offset: 0x38E061 VA: 0x38DF60
	|-ValueTuple<object, object, object>.ToString
	|
	|-RVA: 0x38E170 Offset: 0x38E271 VA: 0x38E170
	|-ValueTuple<object, object, Vector3>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD90 Offset: 0x38DE91 VA: 0x38DD90
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38DF70 Offset: 0x38E071 VA: 0x38DF70
	|-ValueTuple<object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38E180 Offset: 0x38E281 VA: 0x38E180
	|-ValueTuple<object, object, Vector3>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DDA0 Offset: 0x38DEA1 VA: 0x38DDA0
	|-ValueTuple<Int32Enum, Int32Enum, Int32Enum>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38DF80 Offset: 0x38E081 VA: 0x38DF80
	|-ValueTuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38E190 Offset: 0x38E291 VA: 0x38E190
	|-ValueTuple<object, object, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple // TypeDefIndex: 115
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E1A0 Offset: 0x38E2A1 VA: 0x38E1A0
	|-ValueTuple<object, object, object, object>..ctor
	|
	|-RVA: 0x38E3A0 Offset: 0x38E4A1 VA: 0x38E3A0
	|-ValueTuple<object, object, Vector3, float>..ctor
	|-ValueTuple<Collider, FocusInterface, Vector3, float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E210 Offset: 0x38E311 VA: 0x38E210
	|-ValueTuple<object, object, object, object>.Equals
	|
	|-RVA: 0x38E410 Offset: 0x38E511 VA: 0x38E410
	|-ValueTuple<object, object, Vector3, float>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E220 Offset: 0x38E321 VA: 0x38E220
	|-ValueTuple<object, object, object, object>.Equals
	|
	|-RVA: 0x38E420 Offset: 0x38E521 VA: 0x38E420
	|-ValueTuple<object, object, Vector3, float>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E260 Offset: 0x38E361 VA: 0x38E260
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38E460 Offset: 0x38E561 VA: 0x38E460
	|-ValueTuple<object, object, Vector3, float>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E270 Offset: 0x38E371 VA: 0x38E270
	|-ValueTuple<object, object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38E470 Offset: 0x38E571 VA: 0x38E470
	|-ValueTuple<object, object, Vector3, float>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E280 Offset: 0x38E381 VA: 0x38E280
	|-ValueTuple<object, object, object, object>.CompareTo
	|
	|-RVA: 0x38E480 Offset: 0x38E581 VA: 0x38E480
	|-ValueTuple<object, object, Vector3, float>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E2C0 Offset: 0x38E3C1 VA: 0x38E2C0
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38E4C0 Offset: 0x38E5C1 VA: 0x38E4C0
	|-ValueTuple<object, object, Vector3, float>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E2D0 Offset: 0x38E3D1 VA: 0x38E2D0
	|-ValueTuple<object, object, object, object>.GetHashCode
	|
	|-RVA: 0x38E4D0 Offset: 0x38E5D1 VA: 0x38E4D0
	|-ValueTuple<object, object, Vector3, float>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E2E0 Offset: 0x38E3E1 VA: 0x38E2E0
	|-ValueTuple<object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38E4E0 Offset: 0x38E5E1 VA: 0x38E4E0
	|-ValueTuple<object, object, Vector3, float>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E320 Offset: 0x38E421 VA: 0x38E320
	|-ValueTuple<object, object, object, object>.GetHashCodeCore
	|
	|-RVA: 0x38E530 Offset: 0x38E631 VA: 0x38E530
	|-ValueTuple<object, object, Vector3, float>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E330 Offset: 0x38E431 VA: 0x38E330
	|-ValueTuple<object, object, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38E540 Offset: 0x38E641 VA: 0x38E540
	|-ValueTuple<object, object, Vector3, float>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E370 Offset: 0x38E471 VA: 0x38E370
	|-ValueTuple<object, object, object, object>.ToString
	|
	|-RVA: 0x38E590 Offset: 0x38E691 VA: 0x38E590
	|-ValueTuple<object, object, Vector3, float>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E380 Offset: 0x38E481 VA: 0x38E380
	|-ValueTuple<object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38E5A0 Offset: 0x38E6A1 VA: 0x38E5A0
	|-ValueTuple<object, object, Vector3, float>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E390 Offset: 0x38E491 VA: 0x38E390
	|-ValueTuple<object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38E5B0 Offset: 0x38E6B1 VA: 0x38E5B0
	|-ValueTuple<object, object, Vector3, float>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple // TypeDefIndex: 116
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E5C0 Offset: 0x38E6C1 VA: 0x38E5C0
	|-ValueTuple<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E640 Offset: 0x38E741 VA: 0x38E640
	|-ValueTuple<object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E650 Offset: 0x38E751 VA: 0x38E650
	|-ValueTuple<object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E690 Offset: 0x38E791 VA: 0x38E690
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E6A0 Offset: 0x38E7A1 VA: 0x38E6A0
	|-ValueTuple<object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E6B0 Offset: 0x38E7B1 VA: 0x38E6B0
	|-ValueTuple<object, object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E6F0 Offset: 0x38E7F1 VA: 0x38E6F0
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E700 Offset: 0x38E801 VA: 0x38E700
	|-ValueTuple<object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E710 Offset: 0x38E811 VA: 0x38E710
	|-ValueTuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E750 Offset: 0x38E851 VA: 0x38E750
	|-ValueTuple<object, object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E760 Offset: 0x38E861 VA: 0x38E760
	|-ValueTuple<object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E7A0 Offset: 0x38E8A1 VA: 0x38E7A0
	|-ValueTuple<object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E7B0 Offset: 0x38E8B1 VA: 0x38E7B0
	|-ValueTuple<object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E7C0 Offset: 0x38E8C1 VA: 0x38E7C0
	|-ValueTuple<object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal, ITuple // TypeDefIndex: 117
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E7D0 Offset: 0x38E8D1 VA: 0x38E7D0
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>..ctor
	|-ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>..ctor
	|
	|-RVA: 0x38EA50 Offset: 0x38EB51 VA: 0x38EA50
	|-ValueTuple<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E880 Offset: 0x38E981 VA: 0x38E880
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.Equals
	|
	|-RVA: 0x38EAF0 Offset: 0x38EBF1 VA: 0x38EAF0
	|-ValueTuple<object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E890 Offset: 0x38E991 VA: 0x38E890
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.Equals
	|
	|-RVA: 0x38EB00 Offset: 0x38EC01 VA: 0x38EB00
	|-ValueTuple<object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E8E0 Offset: 0x38E9E1 VA: 0x38E8E0
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x38EB40 Offset: 0x38EC41 VA: 0x38EB40
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E8F0 Offset: 0x38E9F1 VA: 0x38E8F0
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x38EB50 Offset: 0x38EC51 VA: 0x38EB50
	|-ValueTuple<object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E900 Offset: 0x38EA01 VA: 0x38E900
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.CompareTo
	|
	|-RVA: 0x38EB60 Offset: 0x38EC61 VA: 0x38EB60
	|-ValueTuple<object, object, object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E950 Offset: 0x38EA51 VA: 0x38E950
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x38EBA0 Offset: 0x38ECA1 VA: 0x38EBA0
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E960 Offset: 0x38EA61 VA: 0x38E960
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.GetHashCode
	|
	|-RVA: 0x38EBB0 Offset: 0x38ECB1 VA: 0x38EBB0
	|-ValueTuple<object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E970 Offset: 0x38EA71 VA: 0x38E970
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x38EBC0 Offset: 0x38ECC1 VA: 0x38EBC0
	|-ValueTuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E9C0 Offset: 0x38EAC1 VA: 0x38E9C0
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.GetHashCodeCore
	|
	|-RVA: 0x38EC00 Offset: 0x38ED01 VA: 0x38EC00
	|-ValueTuple<object, object, object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E9D0 Offset: 0x38EAD1 VA: 0x38E9D0
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x38EC10 Offset: 0x38ED11 VA: 0x38EC10
	|-ValueTuple<object, object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38EA20 Offset: 0x38EB21 VA: 0x38EA20
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.ToString
	|
	|-RVA: 0x38EC50 Offset: 0x38ED51 VA: 0x38EC50
	|-ValueTuple<object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38EA30 Offset: 0x38EB31 VA: 0x38EA30
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x38EC60 Offset: 0x38ED61 VA: 0x38EC60
	|-ValueTuple<object, object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38EA40 Offset: 0x38EB41 VA: 0x38EA40
	|-ValueTuple<int, object, Vector3, Quaternion, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x38EC70 Offset: 0x38ED71 VA: 0x38EC70
	|-ValueTuple<object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IValueTupleInternal, ITuple // TypeDefIndex: 118
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0
	public T7 Item7; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C780 Offset: 0x36C881 VA: 0x36C780
	|-ValueTuple<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C860 Offset: 0x36C961 VA: 0x36C860
	|-ValueTuple<object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C870 Offset: 0x36C971 VA: 0x36C870
	|-ValueTuple<object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8C0 Offset: 0x36C9C1 VA: 0x36C8C0
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8D0 Offset: 0x36C9D1 VA: 0x36C8D0
	|-ValueTuple<object, object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C8E0 Offset: 0x36C9E1 VA: 0x36C8E0
	|-ValueTuple<object, object, object, object, object, object, object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C930 Offset: 0x36CA31 VA: 0x36C930
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C940 Offset: 0x36CA41 VA: 0x36C940
	|-ValueTuple<object, object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C950 Offset: 0x36CA51 VA: 0x36C950
	|-ValueTuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C990 Offset: 0x36CA91 VA: 0x36C990
	|-ValueTuple<object, object, object, object, object, object, object>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C9A0 Offset: 0x36CAA1 VA: 0x36C9A0
	|-ValueTuple<object, object, object, object, object, object, object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C9E0 Offset: 0x36CAE1 VA: 0x36C9E0
	|-ValueTuple<object, object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C9F0 Offset: 0x36CAF1 VA: 0x36C9F0
	|-ValueTuple<object, object, object, object, object, object, object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA00 Offset: 0x36CB01 VA: 0x36CA00
	|-ValueTuple<object, object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple // TypeDefIndex: 119
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0
	public T7 Item7; // 0x0
	public TRest Rest; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
}

