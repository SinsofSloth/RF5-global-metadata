[DefaultMemberAttribute] // RVA: 0xBF150 Offset: 0xBF251 VA: 0xBF150
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 2730
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5C540 Offset: 0x2D5C641 VA: 0x2D5C540
	|-CacheDict<object, object>..ctor
	|-CacheDict<MethodBase, ParameterInfo[]>..ctor
	|-CacheDict<Type, Func<LightLambda, Delegate>>..ctor
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>..ctor
	|-CacheDict<Type, MethodInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5C5E0 Offset: 0x2D5C6E1 VA: 0x2D5C5E0
	|-CacheDict<object, object>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5C600 Offset: 0x2D5C701 VA: 0x2D5C600
	|-CacheDict<object, object>.TryGetValue
	|-CacheDict<MethodBase, ParameterInfo[]>.TryGetValue
	|-CacheDict<Type, Func<LightLambda, Delegate>>.TryGetValue
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>.TryGetValue
	|-CacheDict<Type, MethodInfo>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5C6E0 Offset: 0x2D5C7E1 VA: 0x2D5C6E0
	|-CacheDict<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5C830 Offset: 0x2D5C931 VA: 0x2D5C830
	|-CacheDict<object, object>.set_Item
	|-CacheDict<MethodBase, ParameterInfo[]>.set_Item
	|-CacheDict<Type, Func<LightLambda, Delegate>>.set_Item
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>.set_Item
	|-CacheDict<Type, MethodInfo>.set_Item
	*/
}

