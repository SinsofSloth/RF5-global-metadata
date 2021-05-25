[ComVisibleAttribute] // RVA: 0xABE50 Offset: 0xABF51 VA: 0xABE50
[Serializable]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible // TypeDefIndex: 221
{
	// Fields
	private static readonly char[] enumSeperatorCharArray; // 0x0
	private const string enumSeperator = ", ";

	// Methods

	// RVA: 0x1796DC0 Offset: 0x1796EC1 VA: 0x1796DC0
	private static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) { }

	// RVA: 0x1796FA0 Offset: 0x17970A1 VA: 0x1796FA0
	private static string InternalFormattedHexString(object value) { }

	// RVA: 0x17973F0 Offset: 0x17974F1 VA: 0x17973F0
	private static string InternalFormat(RuntimeType eT, object value) { }

	// RVA: 0x1797610 Offset: 0x1797711 VA: 0x1797610
	private static string InternalFlagsFormat(RuntimeType eT, object value) { }

	// RVA: 0x1797890 Offset: 0x1797991 VA: 0x1797890
	internal static ulong ToUInt64(object value) { }

	// RVA: 0x1797B10 Offset: 0x1797C11 VA: 0x1797B10
	private static int InternalCompareTo(object o1, object o2) { }

	// RVA: 0x1797B20 Offset: 0x1797C21 VA: 0x1797B20
	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) { }

	// RVA: 0x1796F40 Offset: 0x1797041 VA: 0x1796F40
	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) { }

	// RVA: 0x1797B30 Offset: 0x1797C31 VA: 0x1797B30
	private static object InternalBoxEnum(RuntimeType enumType, long value) { }

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C9250 Offset: 0x22C9351 VA: 0x22C9250
	|-Enum.TryParse<BGMID>
	|-Enum.TryParse<AdvScriptId>
	|-Enum.TryParse<ConstraintPresetID>
	|-Enum.TryParse<EffectID>
	|-Enum.TryParse<EventScriptID>
	|-Enum.TryParse<MovieID>
	|-Enum.TryParse<ScoreType>
	|-Enum.TryParse<SkillID>
	|-Enum.TryParse<EquipToolDamageAction>
	|-Enum.TryParse<FocusObjectID>
	|-Enum.TryParse<HumanJointIDEnum>
	|-Enum.TryParse<HumanMagicMotionType>
	|-Enum.TryParse<ItemCategory>
	|-Enum.TryParse<ItemID>
	|-Enum.TryParse<Event>
	|-Enum.TryParse<Master>
	|-Enum.TryParse<Prefab>
	|-Enum.TryParse<Texture>
	|-Enum.TryParse<SkullDragonController.BodyParts>
	|-Enum.TryParse<SoundID>
	|-Enum.TryParse<Int32Enum>
	|-Enum.TryParse<UITextDic.DICID>
	*/

	// RVA: -1 Offset: -1
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C90F0 Offset: 0x22C91F1 VA: 0x22C90F0
	|-Enum.TryParse<Int32Enum>
	*/

	[ComVisibleAttribute] // RVA: 0xB6720 Offset: 0xB6821 VA: 0xB6720
	// RVA: 0x1797B40 Offset: 0x1797C41 VA: 0x1797B40
	public static object Parse(Type enumType, string value) { }

	[ComVisibleAttribute] // RVA: 0xB6740 Offset: 0xB6841 VA: 0xB6740
	// RVA: 0x1797BC0 Offset: 0x1797CC1 VA: 0x1797BC0
	public static object Parse(Type enumType, string value, bool ignoreCase) { }

	// RVA: 0x1797D50 Offset: 0x1797E51 VA: 0x1797D50
	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult) { }

	[ComVisibleAttribute] // RVA: 0xB6760 Offset: 0xB6861 VA: 0xB6760
	// RVA: 0x1798870 Offset: 0x1798971 VA: 0x1798870
	public static Type GetUnderlyingType(Type enumType) { }

	[ComVisibleAttribute] // RVA: 0xB6780 Offset: 0xB6881 VA: 0xB6780
	// RVA: 0x1799020 Offset: 0x1799121 VA: 0x1799020
	public static Array GetValues(Type enumType) { }

	// RVA: 0x17990F0 Offset: 0x17991F1 VA: 0x17990F0
	internal static ulong[] InternalGetValues(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0xB67A0 Offset: 0xB68A1 VA: 0xB67A0
	// RVA: 0x1797530 Offset: 0x1797631 VA: 0x1797530
	public static string GetName(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0xB67C0 Offset: 0xB68C1 VA: 0xB67C0
	// RVA: 0x1799170 Offset: 0x1799271 VA: 0x1799170
	public static string[] GetNames(Type enumType) { }

	// RVA: 0x1799240 Offset: 0x1799341 VA: 0x1799240
	internal static string[] InternalGetNames(RuntimeType enumType) { }

	[ComVisibleAttribute] // RVA: 0xB67E0 Offset: 0xB68E1 VA: 0xB67E0
	// RVA: 0x1798940 Offset: 0x1798A41 VA: 0x1798940
	public static object ToObject(Type enumType, object value) { }

	[ComVisibleAttribute] // RVA: 0xB6800 Offset: 0xB6901 VA: 0xB6800
	// RVA: 0x179A310 Offset: 0x179A411 VA: 0x179A310
	public static bool IsDefined(Type enumType, object value) { }

	// RVA: 0x179A3F0 Offset: 0x179A4F1 VA: 0x179A3F0
	private object get_value() { }

	// RVA: 0x179A400 Offset: 0x179A501 VA: 0x179A400
	internal object GetValue() { }

	// RVA: 0x179A410 Offset: 0x179A511 VA: 0x179A410
	private bool InternalHasFlag(Enum flags) { }

	// RVA: 0x179A420 Offset: 0x179A521 VA: 0x179A420
	private int get_hashcode() { }

	// RVA: 0x179A430 Offset: 0x179A531 VA: 0x179A430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179A440 Offset: 0x179A541 VA: 0x179A440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x179A450 Offset: 0x179A551 VA: 0x179A450 Slot: 3
	public override string ToString() { }

	[ObsoleteAttribute] // RVA: 0xB6820 Offset: 0xB6921 VA: 0xB6820
	// RVA: 0x179A520 Offset: 0x179A621 VA: 0x179A520 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x179A760 Offset: 0x179A861 VA: 0x179A760 Slot: 4
	public int CompareTo(object target) { }

	// RVA: 0x179A530 Offset: 0x179A631 VA: 0x179A530
	public string ToString(string format) { }

	[ObsoleteAttribute] // RVA: 0xB6860 Offset: 0xB6961 VA: 0xB6860
	// RVA: 0x179AA70 Offset: 0x179AB71 VA: 0x179AA70 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x179AA80 Offset: 0x179AB81 VA: 0x179AA80
	public bool HasFlag(Enum flag) { }

	// RVA: 0x179AC30 Offset: 0x179AD31 VA: 0x179AC30 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x179B060 Offset: 0x179B161 VA: 0x179B060 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x179B150 Offset: 0x179B251 VA: 0x179B150 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x179B210 Offset: 0x179B311 VA: 0x179B210 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x179B2D0 Offset: 0x179B3D1 VA: 0x179B2D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x179B390 Offset: 0x179B491 VA: 0x179B390 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x179B450 Offset: 0x179B551 VA: 0x179B450 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x179B510 Offset: 0x179B611 VA: 0x179B510 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x179B5D0 Offset: 0x179B6D1 VA: 0x179B5D0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x179B690 Offset: 0x179B791 VA: 0x179B690 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x179B750 Offset: 0x179B851 VA: 0x179B750 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x179B810 Offset: 0x179B911 VA: 0x179B810 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x179B8D0 Offset: 0x179B9D1 VA: 0x179B8D0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x179B990 Offset: 0x179BA91 VA: 0x179B990 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x179BA50 Offset: 0x179BB51 VA: 0x179BA50 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x179BB40 Offset: 0x179BC41 VA: 0x179BB40 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0xB68A0 Offset: 0xB69A1 VA: 0xB68A0
	[ComVisibleAttribute] // RVA: 0xB68A0 Offset: 0xB69A1 VA: 0xB68A0
	// RVA: 0x1799490 Offset: 0x1799591 VA: 0x1799490
	public static object ToObject(Type enumType, sbyte value) { }

	[ComVisibleAttribute] // RVA: 0xB68E0 Offset: 0xB69E1 VA: 0xB68E0
	// RVA: 0x1799660 Offset: 0x1799761 VA: 0x1799660
	public static object ToObject(Type enumType, short value) { }

	[ComVisibleAttribute] // RVA: 0xB6900 Offset: 0xB6A01 VA: 0xB6900
	// RVA: 0x17992C0 Offset: 0x17993C1 VA: 0x17992C0
	public static object ToObject(Type enumType, int value) { }

	[ComVisibleAttribute] // RVA: 0xB6920 Offset: 0xB6A21 VA: 0xB6920
	// RVA: 0x1799BD0 Offset: 0x1799CD1 VA: 0x1799BD0
	public static object ToObject(Type enumType, byte value) { }

	[ComVisibleAttribute] // RVA: 0xB6940 Offset: 0xB6A41 VA: 0xB6940
	[CLSCompliantAttribute] // RVA: 0xB6940 Offset: 0xB6A41 VA: 0xB6940
	// RVA: 0x1799DA0 Offset: 0x1799EA1 VA: 0x1799DA0
	public static object ToObject(Type enumType, ushort value) { }

	[ComVisibleAttribute] // RVA: 0xB6980 Offset: 0xB6A81 VA: 0xB6980
	[CLSCompliantAttribute] // RVA: 0xB6980 Offset: 0xB6A81 VA: 0xB6980
	// RVA: 0x1799A00 Offset: 0x1799B01 VA: 0x1799A00
	public static object ToObject(Type enumType, uint value) { }

	[ComVisibleAttribute] // RVA: 0xB69C0 Offset: 0xB6AC1 VA: 0xB69C0
	// RVA: 0x1799830 Offset: 0x1799931 VA: 0x1799830
	public static object ToObject(Type enumType, long value) { }

	[CLSCompliantAttribute] // RVA: 0xB69E0 Offset: 0xB6AE1 VA: 0xB69E0
	[ComVisibleAttribute] // RVA: 0xB69E0 Offset: 0xB6AE1 VA: 0xB69E0
	// RVA: 0x1798E50 Offset: 0x1798F51 VA: 0x1798E50
	public static object ToObject(Type enumType, ulong value) { }

	// RVA: 0x1799F70 Offset: 0x179A071 VA: 0x1799F70
	private static object ToObject(Type enumType, char value) { }

	// RVA: 0x179A140 Offset: 0x179A241 VA: 0x179A140
	private static object ToObject(Type enumType, bool value) { }

	// RVA: 0x179BBC0 Offset: 0x179BCC1 VA: 0x179BBC0
	protected void .ctor() { }

	// RVA: 0x179BBD0 Offset: 0x179BCD1 VA: 0x179BBD0
	private static void .cctor() { }
}

