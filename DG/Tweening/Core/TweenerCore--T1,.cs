public class TweenerCore<T1, T2, TPlugOptions> : Tweener // TypeDefIndex: 5085
{
	// Fields
	public T2 startValue; // 0x0
	public T2 endValue; // 0x0
	public T2 changeValue; // 0x0
	public TPlugOptions plugOptions; // 0x0
	public DOGetter<T1> getter; // 0x0
	public DOSetter<T1> setter; // 0x0
	internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin; // 0x0
	private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC4D30 Offset: 0x1AC4E31 VA: 0x1AC4D30
	|-TweenerCore<Color2, Color2, ColorOptions>..ctor
	|
	|-RVA: 0x1AC6550 Offset: 0x1AC6651 VA: 0x1AC6550
	|-TweenerCore<double, double, NoOptions>..ctor
	|
	|-RVA: 0x1AC7B40 Offset: 0x1AC7C41 VA: 0x1AC7B40
	|-TweenerCore<int, int, NoOptions>..ctor
	|
	|-RVA: 0x1AC9150 Offset: 0x1AC9251 VA: 0x1AC9150
	|-TweenerCore<long, long, NoOptions>..ctor
	|
	|-RVA: 0x1ACA760 Offset: 0x1ACA861 VA: 0x1ACA760
	|-TweenerCore<object, object, NoOptions>..ctor
	|
	|-RVA: 0x1ACBD50 Offset: 0x1ACBE51 VA: 0x1ACBD50
	|-TweenerCore<object, object, StringOptions>..ctor
	|
	|-RVA: 0x1ACD3A0 Offset: 0x1ACD4A1 VA: 0x1ACD3A0
	|-TweenerCore<float, float, FloatOptions>..ctor
	|
	|-RVA: 0x1ACE990 Offset: 0x1ACEA91 VA: 0x1ACE990
	|-TweenerCore<uint, uint, UintOptions>..ctor
	|
	|-RVA: 0x1ACFFA0 Offset: 0x1AD00A1 VA: 0x1ACFFA0
	|-TweenerCore<ulong, ulong, NoOptions>..ctor
	|
	|-RVA: 0x1AD15B0 Offset: 0x1AD16B1 VA: 0x1AD15B0
	|-TweenerCore<Color, Color, ColorOptions>..ctor
	|
	|-RVA: 0x1AD2CB0 Offset: 0x1AD2DB1 VA: 0x1AD2CB0
	|-TweenerCore<Quaternion, Quaternion, NoOptions>..ctor
	|
	|-RVA: 0x1AD43B0 Offset: 0x1AD44B1 VA: 0x1AD43B0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>..ctor
	|
	|-RVA: 0x1AD5AA0 Offset: 0x1AD5BA1 VA: 0x1AD5AA0
	|-TweenerCore<Rect, Rect, RectOptions>..ctor
	|
	|-RVA: 0x2C800D0 Offset: 0x2C801D1 VA: 0x2C800D0
	|-TweenerCore<Vector2, Vector2, VectorOptions>..ctor
	|
	|-RVA: 0x2C81730 Offset: 0x2C81831 VA: 0x2C81730
	|-TweenerCore<Vector3, object, PathOptions>..ctor
	|
	|-RVA: 0x2C82E20 Offset: 0x2C82F21 VA: 0x2C82E20
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>..ctor
	|
	|-RVA: 0x2C84410 Offset: 0x2C84511 VA: 0x2C84410
	|-TweenerCore<Vector3, Vector3, VectorOptions>..ctor
	|
	|-RVA: 0x2C85AA0 Offset: 0x2C85BA1 VA: 0x2C85AA0
	|-TweenerCore<Vector4, Vector4, VectorOptions>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC4E30 Offset: 0x1AC4F31 VA: 0x1AC4E30
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC6650 Offset: 0x1AC6751 VA: 0x1AC6650
	|-TweenerCore<double, double, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC7C40 Offset: 0x1AC7D41 VA: 0x1AC7C40
	|-TweenerCore<int, int, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC9250 Offset: 0x1AC9351 VA: 0x1AC9250
	|-TweenerCore<long, long, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACA860 Offset: 0x1ACA961 VA: 0x1ACA860
	|-TweenerCore<object, object, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACBE50 Offset: 0x1ACBF51 VA: 0x1ACBE50
	|-TweenerCore<object, object, StringOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACD4A0 Offset: 0x1ACD5A1 VA: 0x1ACD4A0
	|-TweenerCore<float, float, FloatOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACEA90 Offset: 0x1ACEB91 VA: 0x1ACEA90
	|-TweenerCore<uint, uint, UintOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD00A0 Offset: 0x1AD01A1 VA: 0x1AD00A0
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD16B0 Offset: 0x1AD17B1 VA: 0x1AD16B0
	|-TweenerCore<Color, Color, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD2DB0 Offset: 0x1AD2EB1 VA: 0x1AD2DB0
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD44B0 Offset: 0x1AD45B1 VA: 0x1AD44B0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD5BA0 Offset: 0x1AD5CA1 VA: 0x1AD5BA0
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeStartValue
	|
	|-RVA: 0x2C801D0 Offset: 0x2C802D1 VA: 0x2C801D0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x2C81830 Offset: 0x2C81931 VA: 0x2C81830
	|-TweenerCore<Vector3, object, PathOptions>.ChangeStartValue
	|
	|-RVA: 0x2C82F20 Offset: 0x2C83021 VA: 0x2C82F20
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeStartValue
	|
	|-RVA: 0x2C84510 Offset: 0x2C84611 VA: 0x2C84510
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x2C85BA0 Offset: 0x2C85CA1 VA: 0x2C85BA0
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeStartValue
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC51F0 Offset: 0x1AC52F1 VA: 0x1AC51F0
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC6A00 Offset: 0x1AC6B01 VA: 0x1AC6A00
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC7FF0 Offset: 0x1AC80F1 VA: 0x1AC7FF0
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC9600 Offset: 0x1AC9701 VA: 0x1AC9600
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACAC00 Offset: 0x1ACAD01 VA: 0x1ACAC00
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACC1F0 Offset: 0x1ACC2F1 VA: 0x1ACC1F0
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACD850 Offset: 0x1ACD951 VA: 0x1ACD850
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACEE40 Offset: 0x1ACEF41 VA: 0x1ACEE40
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD0450 Offset: 0x1AD0551 VA: 0x1AD0450
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD1A60 Offset: 0x1AD1B61 VA: 0x1AD1A60
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD3160 Offset: 0x1AD3261 VA: 0x1AD3160
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD4860 Offset: 0x1AD4961 VA: 0x1AD4860
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD5F50 Offset: 0x1AD6051 VA: 0x1AD5F50
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x2C80580 Offset: 0x2C80681 VA: 0x2C80580
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C81BD0 Offset: 0x2C81CD1 VA: 0x2C81BD0
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x2C832C0 Offset: 0x2C833C1 VA: 0x2C832C0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x2C848C0 Offset: 0x2C849C1 VA: 0x2C848C0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C85F50 Offset: 0x2C86051 VA: 0x2C85F50
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5220 Offset: 0x1AC5321 VA: 0x1AC5220
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC6A30 Offset: 0x1AC6B31 VA: 0x1AC6A30
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC8020 Offset: 0x1AC8121 VA: 0x1AC8020
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC9630 Offset: 0x1AC9731 VA: 0x1AC9630
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACAC30 Offset: 0x1ACAD31 VA: 0x1ACAC30
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACC220 Offset: 0x1ACC321 VA: 0x1ACC220
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACD880 Offset: 0x1ACD981 VA: 0x1ACD880
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACEE70 Offset: 0x1ACEF71 VA: 0x1ACEE70
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD0480 Offset: 0x1AD0581 VA: 0x1AD0480
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD1A90 Offset: 0x1AD1B91 VA: 0x1AD1A90
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD3190 Offset: 0x1AD3291 VA: 0x1AD3190
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD4890 Offset: 0x1AD4991 VA: 0x1AD4890
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD5F80 Offset: 0x1AD6081 VA: 0x1AD5F80
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x2C805B0 Offset: 0x2C806B1 VA: 0x2C805B0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C81C00 Offset: 0x2C81D01 VA: 0x2C81C00
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x2C832F0 Offset: 0x2C833F1 VA: 0x2C832F0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x2C848F0 Offset: 0x2C849F1 VA: 0x2C848F0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C85F80 Offset: 0x2C86081 VA: 0x2C85F80
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC55F0 Offset: 0x1AC56F1 VA: 0x1AC55F0
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeValues
	|
	|-RVA: 0x1AC6E00 Offset: 0x1AC6F01 VA: 0x1AC6E00
	|-TweenerCore<double, double, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AC83F0 Offset: 0x1AC84F1 VA: 0x1AC83F0
	|-TweenerCore<int, int, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AC9A00 Offset: 0x1AC9B01 VA: 0x1AC9A00
	|-TweenerCore<long, long, NoOptions>.ChangeValues
	|
	|-RVA: 0x1ACB000 Offset: 0x1ACB101 VA: 0x1ACB000
	|-TweenerCore<object, object, NoOptions>.ChangeValues
	|
	|-RVA: 0x1ACC5F0 Offset: 0x1ACC6F1 VA: 0x1ACC5F0
	|-TweenerCore<object, object, StringOptions>.ChangeValues
	|
	|-RVA: 0x1ACDC50 Offset: 0x1ACDD51 VA: 0x1ACDC50
	|-TweenerCore<float, float, FloatOptions>.ChangeValues
	|
	|-RVA: 0x1ACF240 Offset: 0x1ACF341 VA: 0x1ACF240
	|-TweenerCore<uint, uint, UintOptions>.ChangeValues
	|
	|-RVA: 0x1AD0850 Offset: 0x1AD0951 VA: 0x1AD0850
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AD1E60 Offset: 0x1AD1F61 VA: 0x1AD1E60
	|-TweenerCore<Color, Color, ColorOptions>.ChangeValues
	|
	|-RVA: 0x1AD3560 Offset: 0x1AD3661 VA: 0x1AD3560
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AD4C60 Offset: 0x1AD4D61 VA: 0x1AD4C60
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeValues
	|
	|-RVA: 0x1AD6350 Offset: 0x1AD6451 VA: 0x1AD6350
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeValues
	|
	|-RVA: 0x2C80980 Offset: 0x2C80A81 VA: 0x2C80980
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeValues
	|
	|-RVA: 0x2C81FD0 Offset: 0x2C820D1 VA: 0x2C81FD0
	|-TweenerCore<Vector3, object, PathOptions>.ChangeValues
	|
	|-RVA: 0x2C836C0 Offset: 0x2C837C1 VA: 0x2C836C0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeValues
	|
	|-RVA: 0x2C84CC0 Offset: 0x2C84DC1 VA: 0x2C84CC0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeValues
	|
	|-RVA: 0x2C86350 Offset: 0x2C86451 VA: 0x2C86350
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeValues
	*/

	// RVA: -1 Offset: -1
	public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5BD0 Offset: 0x1AC5CD1 VA: 0x1AC5BD0
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC73D0 Offset: 0x1AC74D1 VA: 0x1AC73D0
	|-TweenerCore<double, double, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC89C0 Offset: 0x1AC8AC1 VA: 0x1AC89C0
	|-TweenerCore<int, int, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AC9FD0 Offset: 0x1ACA0D1 VA: 0x1AC9FD0
	|-TweenerCore<long, long, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACB5C0 Offset: 0x1ACB6C1 VA: 0x1ACB5C0
	|-TweenerCore<object, object, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACCBB0 Offset: 0x1ACCCB1 VA: 0x1ACCBB0
	|-TweenerCore<object, object, StringOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACE220 Offset: 0x1ACE321 VA: 0x1ACE220
	|-TweenerCore<float, float, FloatOptions>.ChangeStartValue
	|
	|-RVA: 0x1ACF810 Offset: 0x1ACF911 VA: 0x1ACF810
	|-TweenerCore<uint, uint, UintOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD0E20 Offset: 0x1AD0F21 VA: 0x1AD0E20
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD2440 Offset: 0x1AD2541 VA: 0x1AD2440
	|-TweenerCore<Color, Color, ColorOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD3B40 Offset: 0x1AD3C41 VA: 0x1AD3B40
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD5250 Offset: 0x1AD5351 VA: 0x1AD5250
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeStartValue
	|
	|-RVA: 0x1AD6930 Offset: 0x1AD6A31 VA: 0x1AD6930
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeStartValue
	|
	|-RVA: 0x2C80F60 Offset: 0x2C81061 VA: 0x2C80F60
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x2C82590 Offset: 0x2C82691 VA: 0x2C82590
	|-TweenerCore<Vector3, object, PathOptions>.ChangeStartValue
	|
	|-RVA: 0x2C83C80 Offset: 0x2C83D81 VA: 0x2C83C80
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeStartValue
	|
	|-RVA: 0x2C852B0 Offset: 0x2C853B1 VA: 0x2C852B0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeStartValue
	|
	|-RVA: 0x2C86930 Offset: 0x2C86A31 VA: 0x2C86930
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeStartValue
	*/

	// RVA: -1 Offset: -1
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5CF0 Offset: 0x1AC5DF1 VA: 0x1AC5CF0
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC74D0 Offset: 0x1AC75D1 VA: 0x1AC74D0
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC8AC0 Offset: 0x1AC8BC1 VA: 0x1AC8AC0
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACA0D0 Offset: 0x1ACA1D1 VA: 0x1ACA0D0
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACB6C0 Offset: 0x1ACB7C1 VA: 0x1ACB6C0
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACCCB0 Offset: 0x1ACCDB1 VA: 0x1ACCCB0
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACE320 Offset: 0x1ACE421 VA: 0x1ACE320
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACF910 Offset: 0x1ACFA11 VA: 0x1ACF910
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD0F20 Offset: 0x1AD1021 VA: 0x1AD0F20
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD2570 Offset: 0x1AD2671 VA: 0x1AD2570
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD3C70 Offset: 0x1AD3D71 VA: 0x1AD3C70
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD5360 Offset: 0x1AD5461 VA: 0x1AD5360
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD6A60 Offset: 0x1AD6B61 VA: 0x1AD6A60
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x2C81070 Offset: 0x2C81171 VA: 0x2C81070
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C82690 Offset: 0x2C82791 VA: 0x2C82690
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x2C83D80 Offset: 0x2C83E81 VA: 0x2C83D80
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x2C853C0 Offset: 0x2C854C1 VA: 0x2C853C0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C86A60 Offset: 0x2C86B61 VA: 0x2C86A60
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1
	public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1, bool snapStartValue = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5D60 Offset: 0x1AC5E61 VA: 0x1AC5D60
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC7500 Offset: 0x1AC7601 VA: 0x1AC7500
	|-TweenerCore<double, double, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AC8AF0 Offset: 0x1AC8BF1 VA: 0x1AC8AF0
	|-TweenerCore<int, int, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACA100 Offset: 0x1ACA201 VA: 0x1ACA100
	|-TweenerCore<long, long, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACB6F0 Offset: 0x1ACB7F1 VA: 0x1ACB6F0
	|-TweenerCore<object, object, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACCCE0 Offset: 0x1ACCDE1 VA: 0x1ACCCE0
	|-TweenerCore<object, object, StringOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACE350 Offset: 0x1ACE451 VA: 0x1ACE350
	|-TweenerCore<float, float, FloatOptions>.ChangeEndValue
	|
	|-RVA: 0x1ACF940 Offset: 0x1ACFA41 VA: 0x1ACF940
	|-TweenerCore<uint, uint, UintOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD0F50 Offset: 0x1AD1051 VA: 0x1AD0F50
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD25A0 Offset: 0x1AD26A1 VA: 0x1AD25A0
	|-TweenerCore<Color, Color, ColorOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD3CA0 Offset: 0x1AD3DA1 VA: 0x1AD3CA0
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD5390 Offset: 0x1AD5491 VA: 0x1AD5390
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeEndValue
	|
	|-RVA: 0x1AD6A90 Offset: 0x1AD6B91 VA: 0x1AD6A90
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeEndValue
	|
	|-RVA: 0x2C810A0 Offset: 0x2C811A1 VA: 0x2C810A0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C826C0 Offset: 0x2C827C1 VA: 0x2C826C0
	|-TweenerCore<Vector3, object, PathOptions>.ChangeEndValue
	|
	|-RVA: 0x2C83DB0 Offset: 0x2C83EB1 VA: 0x2C83DB0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeEndValue
	|
	|-RVA: 0x2C853F0 Offset: 0x2C854F1 VA: 0x2C853F0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeEndValue
	|
	|-RVA: 0x2C86A90 Offset: 0x2C86B91 VA: 0x2C86A90
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeEndValue
	*/

	// RVA: -1 Offset: -1
	public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5E90 Offset: 0x1AC5F91 VA: 0x1AC5E90
	|-TweenerCore<Color2, Color2, ColorOptions>.ChangeValues
	|
	|-RVA: 0x1AC7600 Offset: 0x1AC7701 VA: 0x1AC7600
	|-TweenerCore<double, double, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AC8C00 Offset: 0x1AC8D01 VA: 0x1AC8C00
	|-TweenerCore<int, int, NoOptions>.ChangeValues
	|
	|-RVA: 0x1ACA210 Offset: 0x1ACA311 VA: 0x1ACA210
	|-TweenerCore<long, long, NoOptions>.ChangeValues
	|
	|-RVA: 0x1ACB800 Offset: 0x1ACB901 VA: 0x1ACB800
	|-TweenerCore<object, object, NoOptions>.ChangeValues
	|
	|-RVA: 0x1ACCDF0 Offset: 0x1ACCEF1 VA: 0x1ACCDF0
	|-TweenerCore<object, object, StringOptions>.ChangeValues
	|
	|-RVA: 0x1ACE450 Offset: 0x1ACE551 VA: 0x1ACE450
	|-TweenerCore<float, float, FloatOptions>.ChangeValues
	|
	|-RVA: 0x1ACFA50 Offset: 0x1ACFB51 VA: 0x1ACFA50
	|-TweenerCore<uint, uint, UintOptions>.ChangeValues
	|
	|-RVA: 0x1AD1060 Offset: 0x1AD1161 VA: 0x1AD1060
	|-TweenerCore<ulong, ulong, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AD26D0 Offset: 0x1AD27D1 VA: 0x1AD26D0
	|-TweenerCore<Color, Color, ColorOptions>.ChangeValues
	|
	|-RVA: 0x1AD3DD0 Offset: 0x1AD3ED1 VA: 0x1AD3DD0
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ChangeValues
	|
	|-RVA: 0x1AD54B0 Offset: 0x1AD55B1 VA: 0x1AD54B0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ChangeValues
	|
	|-RVA: 0x1AD6BC0 Offset: 0x1AD6CC1 VA: 0x1AD6BC0
	|-TweenerCore<Rect, Rect, RectOptions>.ChangeValues
	|
	|-RVA: 0x2C811B0 Offset: 0x2C812B1 VA: 0x2C811B0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ChangeValues
	|
	|-RVA: 0x2C827D0 Offset: 0x2C828D1 VA: 0x2C827D0
	|-TweenerCore<Vector3, object, PathOptions>.ChangeValues
	|
	|-RVA: 0x2C83EC0 Offset: 0x2C83FC1 VA: 0x2C83EC0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ChangeValues
	|
	|-RVA: 0x2C85510 Offset: 0x2C85611 VA: 0x2C85510
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ChangeValues
	|
	|-RVA: 0x2C86BC0 Offset: 0x2C86CC1 VA: 0x2C86BC0
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ChangeValues
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Tweener SetFrom(bool relative) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC5FE0 Offset: 0x1AC60E1 VA: 0x1AC5FE0
	|-TweenerCore<Color2, Color2, ColorOptions>.SetFrom
	|
	|-RVA: 0x1AC7710 Offset: 0x1AC7811 VA: 0x1AC7710
	|-TweenerCore<double, double, NoOptions>.SetFrom
	|
	|-RVA: 0x1AC8D10 Offset: 0x1AC8E11 VA: 0x1AC8D10
	|-TweenerCore<int, int, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACA320 Offset: 0x1ACA421 VA: 0x1ACA320
	|-TweenerCore<long, long, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACB910 Offset: 0x1ACBA11 VA: 0x1ACB910
	|-TweenerCore<object, object, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACCF00 Offset: 0x1ACD001 VA: 0x1ACCF00
	|-TweenerCore<object, object, StringOptions>.SetFrom
	|
	|-RVA: 0x1ACE560 Offset: 0x1ACE661 VA: 0x1ACE560
	|-TweenerCore<float, float, FloatOptions>.SetFrom
	|
	|-RVA: 0x1ACFB60 Offset: 0x1ACFC61 VA: 0x1ACFB60
	|-TweenerCore<uint, uint, UintOptions>.SetFrom
	|
	|-RVA: 0x1AD1170 Offset: 0x1AD1271 VA: 0x1AD1170
	|-TweenerCore<ulong, ulong, NoOptions>.SetFrom
	|
	|-RVA: 0x1AD2830 Offset: 0x1AD2931 VA: 0x1AD2830
	|-TweenerCore<Color, Color, ColorOptions>.SetFrom
	|
	|-RVA: 0x1AD3F30 Offset: 0x1AD4031 VA: 0x1AD3F30
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.SetFrom
	|
	|-RVA: 0x1AD55F0 Offset: 0x1AD56F1 VA: 0x1AD55F0
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.SetFrom
	|
	|-RVA: 0x1AD6D20 Offset: 0x1AD6E21 VA: 0x1AD6D20
	|-TweenerCore<Rect, Rect, RectOptions>.SetFrom
	|
	|-RVA: 0x2C812E0 Offset: 0x2C813E1 VA: 0x2C812E0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.SetFrom
	|
	|-RVA: 0x2C828E0 Offset: 0x2C829E1 VA: 0x2C828E0
	|-TweenerCore<Vector3, object, PathOptions>.SetFrom
	|
	|-RVA: 0x2C83FD0 Offset: 0x2C840D1 VA: 0x2C83FD0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.SetFrom
	|
	|-RVA: 0x2C85650 Offset: 0x2C85751 VA: 0x2C85650
	|-TweenerCore<Vector3, Vector3, VectorOptions>.SetFrom
	|
	|-RVA: 0x2C86D20 Offset: 0x2C86E21 VA: 0x2C86D20
	|-TweenerCore<Vector4, Vector4, VectorOptions>.SetFrom
	*/

	// RVA: -1 Offset: -1
	internal Tweener SetFrom(T2 fromValue, bool setImmediately) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC6030 Offset: 0x1AC6131 VA: 0x1AC6030
	|-TweenerCore<Color2, Color2, ColorOptions>.SetFrom
	|
	|-RVA: 0x1AC7760 Offset: 0x1AC7861 VA: 0x1AC7760
	|-TweenerCore<double, double, NoOptions>.SetFrom
	|
	|-RVA: 0x1AC8D60 Offset: 0x1AC8E61 VA: 0x1AC8D60
	|-TweenerCore<int, int, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACA370 Offset: 0x1ACA471 VA: 0x1ACA370
	|-TweenerCore<long, long, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACB960 Offset: 0x1ACBA61 VA: 0x1ACB960
	|-TweenerCore<object, object, NoOptions>.SetFrom
	|
	|-RVA: 0x1ACCF50 Offset: 0x1ACD051 VA: 0x1ACCF50
	|-TweenerCore<object, object, StringOptions>.SetFrom
	|
	|-RVA: 0x1ACE5B0 Offset: 0x1ACE6B1 VA: 0x1ACE5B0
	|-TweenerCore<float, float, FloatOptions>.SetFrom
	|
	|-RVA: 0x1ACFBB0 Offset: 0x1ACFCB1 VA: 0x1ACFBB0
	|-TweenerCore<uint, uint, UintOptions>.SetFrom
	|
	|-RVA: 0x1AD11C0 Offset: 0x1AD12C1 VA: 0x1AD11C0
	|-TweenerCore<ulong, ulong, NoOptions>.SetFrom
	|
	|-RVA: 0x1AD2880 Offset: 0x1AD2981 VA: 0x1AD2880
	|-TweenerCore<Color, Color, ColorOptions>.SetFrom
	|
	|-RVA: 0x1AD3F80 Offset: 0x1AD4081 VA: 0x1AD3F80
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.SetFrom
	|
	|-RVA: 0x1AD5640 Offset: 0x1AD5741 VA: 0x1AD5640
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.SetFrom
	|
	|-RVA: 0x1AD6D70 Offset: 0x1AD6E71 VA: 0x1AD6D70
	|-TweenerCore<Rect, Rect, RectOptions>.SetFrom
	|
	|-RVA: 0x2C81330 Offset: 0x2C81431 VA: 0x2C81330
	|-TweenerCore<Vector2, Vector2, VectorOptions>.SetFrom
	|
	|-RVA: 0x2C82930 Offset: 0x2C82A31 VA: 0x2C82930
	|-TweenerCore<Vector3, object, PathOptions>.SetFrom
	|
	|-RVA: 0x2C84020 Offset: 0x2C84121 VA: 0x2C84020
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.SetFrom
	|
	|-RVA: 0x2C856A0 Offset: 0x2C857A1 VA: 0x2C856A0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.SetFrom
	|
	|-RVA: 0x2C86D70 Offset: 0x2C86E71 VA: 0x2C86D70
	|-TweenerCore<Vector4, Vector4, VectorOptions>.SetFrom
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal sealed override void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC60B0 Offset: 0x1AC61B1 VA: 0x1AC60B0
	|-TweenerCore<Color2, Color2, ColorOptions>.Reset
	|
	|-RVA: 0x1AC77B0 Offset: 0x1AC78B1 VA: 0x1AC77B0
	|-TweenerCore<double, double, NoOptions>.Reset
	|
	|-RVA: 0x1AC8DB0 Offset: 0x1AC8EB1 VA: 0x1AC8DB0
	|-TweenerCore<int, int, NoOptions>.Reset
	|
	|-RVA: 0x1ACA3C0 Offset: 0x1ACA4C1 VA: 0x1ACA3C0
	|-TweenerCore<long, long, NoOptions>.Reset
	|
	|-RVA: 0x1ACB9B0 Offset: 0x1ACBAB1 VA: 0x1ACB9B0
	|-TweenerCore<object, object, NoOptions>.Reset
	|
	|-RVA: 0x1ACCFA0 Offset: 0x1ACD0A1 VA: 0x1ACCFA0
	|-TweenerCore<object, object, StringOptions>.Reset
	|
	|-RVA: 0x1ACE600 Offset: 0x1ACE701 VA: 0x1ACE600
	|-TweenerCore<float, float, FloatOptions>.Reset
	|
	|-RVA: 0x1ACFC00 Offset: 0x1ACFD01 VA: 0x1ACFC00
	|-TweenerCore<uint, uint, UintOptions>.Reset
	|
	|-RVA: 0x1AD1210 Offset: 0x1AD1311 VA: 0x1AD1210
	|-TweenerCore<ulong, ulong, NoOptions>.Reset
	|
	|-RVA: 0x1AD28D0 Offset: 0x1AD29D1 VA: 0x1AD28D0
	|-TweenerCore<Color, Color, ColorOptions>.Reset
	|
	|-RVA: 0x1AD3FD0 Offset: 0x1AD40D1 VA: 0x1AD3FD0
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Reset
	|
	|-RVA: 0x1AD5690 Offset: 0x1AD5791 VA: 0x1AD5690
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Reset
	|
	|-RVA: 0x1AD6DC0 Offset: 0x1AD6EC1 VA: 0x1AD6DC0
	|-TweenerCore<Rect, Rect, RectOptions>.Reset
	|
	|-RVA: 0x2C81380 Offset: 0x2C81481 VA: 0x2C81380
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Reset
	|
	|-RVA: 0x2C82980 Offset: 0x2C82A81 VA: 0x2C82980
	|-TweenerCore<Vector3, object, PathOptions>.Reset
	|
	|-RVA: 0x2C84070 Offset: 0x2C84171 VA: 0x2C84070
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Reset
	|
	|-RVA: 0x2C856F0 Offset: 0x2C857F1 VA: 0x2C856F0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Reset
	|
	|-RVA: 0x2C86DC0 Offset: 0x2C86EC1 VA: 0x2C86DC0
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override bool Validate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC6130 Offset: 0x1AC6231 VA: 0x1AC6130
	|-TweenerCore<Color2, Color2, ColorOptions>.Validate
	|
	|-RVA: 0x1AC7830 Offset: 0x1AC7931 VA: 0x1AC7830
	|-TweenerCore<double, double, NoOptions>.Validate
	|
	|-RVA: 0x1AC8E30 Offset: 0x1AC8F31 VA: 0x1AC8E30
	|-TweenerCore<int, int, NoOptions>.Validate
	|
	|-RVA: 0x1ACA440 Offset: 0x1ACA541 VA: 0x1ACA440
	|-TweenerCore<long, long, NoOptions>.Validate
	|
	|-RVA: 0x1ACBA30 Offset: 0x1ACBB31 VA: 0x1ACBA30
	|-TweenerCore<object, object, NoOptions>.Validate
	|
	|-RVA: 0x1ACD020 Offset: 0x1ACD121 VA: 0x1ACD020
	|-TweenerCore<object, object, StringOptions>.Validate
	|
	|-RVA: 0x1ACE680 Offset: 0x1ACE781 VA: 0x1ACE680
	|-TweenerCore<float, float, FloatOptions>.Validate
	|
	|-RVA: 0x1ACFC80 Offset: 0x1ACFD81 VA: 0x1ACFC80
	|-TweenerCore<uint, uint, UintOptions>.Validate
	|
	|-RVA: 0x1AD1290 Offset: 0x1AD1391 VA: 0x1AD1290
	|-TweenerCore<ulong, ulong, NoOptions>.Validate
	|
	|-RVA: 0x1AD2950 Offset: 0x1AD2A51 VA: 0x1AD2950
	|-TweenerCore<Color, Color, ColorOptions>.Validate
	|
	|-RVA: 0x1AD4050 Offset: 0x1AD4151 VA: 0x1AD4050
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Validate
	|
	|-RVA: 0x1AD5710 Offset: 0x1AD5811 VA: 0x1AD5710
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Validate
	|
	|-RVA: 0x1AD6E40 Offset: 0x1AD6F41 VA: 0x1AD6E40
	|-TweenerCore<Rect, Rect, RectOptions>.Validate
	|
	|-RVA: 0x2C81400 Offset: 0x2C81501 VA: 0x2C81400
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Validate
	|
	|-RVA: 0x2C82A00 Offset: 0x2C82B01 VA: 0x2C82A00
	|-TweenerCore<Vector3, object, PathOptions>.Validate
	|
	|-RVA: 0x2C840F0 Offset: 0x2C841F1 VA: 0x2C840F0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Validate
	|
	|-RVA: 0x2C85770 Offset: 0x2C85871 VA: 0x2C85770
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Validate
	|
	|-RVA: 0x2C86E40 Offset: 0x2C86F41 VA: 0x2C86E40
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Validate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override float UpdateDelay(float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC6230 Offset: 0x1AC6331 VA: 0x1AC6230
	|-TweenerCore<Color2, Color2, ColorOptions>.UpdateDelay
	|
	|-RVA: 0x1AC7920 Offset: 0x1AC7A21 VA: 0x1AC7920
	|-TweenerCore<double, double, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1AC8F20 Offset: 0x1AC9021 VA: 0x1AC8F20
	|-TweenerCore<int, int, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1ACA530 Offset: 0x1ACA631 VA: 0x1ACA530
	|-TweenerCore<long, long, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1ACBB20 Offset: 0x1ACBC21 VA: 0x1ACBB20
	|-TweenerCore<object, object, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1ACD110 Offset: 0x1ACD211 VA: 0x1ACD110
	|-TweenerCore<object, object, StringOptions>.UpdateDelay
	|
	|-RVA: 0x1ACE770 Offset: 0x1ACE871 VA: 0x1ACE770
	|-TweenerCore<float, float, FloatOptions>.UpdateDelay
	|
	|-RVA: 0x1ACFD70 Offset: 0x1ACFE71 VA: 0x1ACFD70
	|-TweenerCore<uint, uint, UintOptions>.UpdateDelay
	|
	|-RVA: 0x1AD1380 Offset: 0x1AD1481 VA: 0x1AD1380
	|-TweenerCore<ulong, ulong, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1AD2A40 Offset: 0x1AD2B41 VA: 0x1AD2A40
	|-TweenerCore<Color, Color, ColorOptions>.UpdateDelay
	|
	|-RVA: 0x1AD4140 Offset: 0x1AD4241 VA: 0x1AD4140
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.UpdateDelay
	|
	|-RVA: 0x1AD5800 Offset: 0x1AD5901 VA: 0x1AD5800
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.UpdateDelay
	|
	|-RVA: 0x1AD6F30 Offset: 0x1AD7031 VA: 0x1AD6F30
	|-TweenerCore<Rect, Rect, RectOptions>.UpdateDelay
	|
	|-RVA: 0x2C814F0 Offset: 0x2C815F1 VA: 0x2C814F0
	|-TweenerCore<Vector2, Vector2, VectorOptions>.UpdateDelay
	|
	|-RVA: 0x2C82AF0 Offset: 0x2C82BF1 VA: 0x2C82AF0
	|-TweenerCore<Vector3, object, PathOptions>.UpdateDelay
	|
	|-RVA: 0x2C841E0 Offset: 0x2C842E1 VA: 0x2C841E0
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.UpdateDelay
	|
	|-RVA: 0x2C85860 Offset: 0x2C85961 VA: 0x2C85860
	|-TweenerCore<Vector3, Vector3, VectorOptions>.UpdateDelay
	|
	|-RVA: 0x2C86F30 Offset: 0x2C87031 VA: 0x2C86F30
	|-TweenerCore<Vector4, Vector4, VectorOptions>.UpdateDelay
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override bool Startup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC6250 Offset: 0x1AC6351 VA: 0x1AC6250
	|-TweenerCore<Color2, Color2, ColorOptions>.Startup
	|
	|-RVA: 0x1AC7940 Offset: 0x1AC7A41 VA: 0x1AC7940
	|-TweenerCore<double, double, NoOptions>.Startup
	|
	|-RVA: 0x1AC8F40 Offset: 0x1AC9041 VA: 0x1AC8F40
	|-TweenerCore<int, int, NoOptions>.Startup
	|
	|-RVA: 0x1ACA550 Offset: 0x1ACA651 VA: 0x1ACA550
	|-TweenerCore<long, long, NoOptions>.Startup
	|
	|-RVA: 0x1ACBB40 Offset: 0x1ACBC41 VA: 0x1ACBB40
	|-TweenerCore<object, object, NoOptions>.Startup
	|
	|-RVA: 0x1ACD130 Offset: 0x1ACD231 VA: 0x1ACD130
	|-TweenerCore<object, object, StringOptions>.Startup
	|
	|-RVA: 0x1ACE790 Offset: 0x1ACE891 VA: 0x1ACE790
	|-TweenerCore<float, float, FloatOptions>.Startup
	|
	|-RVA: 0x1ACFD90 Offset: 0x1ACFE91 VA: 0x1ACFD90
	|-TweenerCore<uint, uint, UintOptions>.Startup
	|
	|-RVA: 0x1AD13A0 Offset: 0x1AD14A1 VA: 0x1AD13A0
	|-TweenerCore<ulong, ulong, NoOptions>.Startup
	|
	|-RVA: 0x1AD2A60 Offset: 0x1AD2B61 VA: 0x1AD2A60
	|-TweenerCore<Color, Color, ColorOptions>.Startup
	|
	|-RVA: 0x1AD4160 Offset: 0x1AD4261 VA: 0x1AD4160
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.Startup
	|
	|-RVA: 0x1AD5820 Offset: 0x1AD5921 VA: 0x1AD5820
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.Startup
	|
	|-RVA: 0x1AD6F50 Offset: 0x1AD7051 VA: 0x1AD6F50
	|-TweenerCore<Rect, Rect, RectOptions>.Startup
	|
	|-RVA: 0x2C81510 Offset: 0x2C81611 VA: 0x2C81510
	|-TweenerCore<Vector2, Vector2, VectorOptions>.Startup
	|
	|-RVA: 0x2C82B10 Offset: 0x2C82C11 VA: 0x2C82B10
	|-TweenerCore<Vector3, object, PathOptions>.Startup
	|
	|-RVA: 0x2C84200 Offset: 0x2C84301 VA: 0x2C84200
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.Startup
	|
	|-RVA: 0x2C85880 Offset: 0x2C85981 VA: 0x2C85880
	|-TweenerCore<Vector3, Vector3, VectorOptions>.Startup
	|
	|-RVA: 0x2C86F50 Offset: 0x2C87051 VA: 0x2C86F50
	|-TweenerCore<Vector4, Vector4, VectorOptions>.Startup
	*/

	// RVA: -1 Offset: -1 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AC6270 Offset: 0x1AC6371 VA: 0x1AC6270
	|-TweenerCore<Color2, Color2, ColorOptions>.ApplyTween
	|
	|-RVA: 0x1AC7960 Offset: 0x1AC7A61 VA: 0x1AC7960
	|-TweenerCore<double, double, NoOptions>.ApplyTween
	|
	|-RVA: 0x1AC8F60 Offset: 0x1AC9061 VA: 0x1AC8F60
	|-TweenerCore<int, int, NoOptions>.ApplyTween
	|
	|-RVA: 0x1ACA570 Offset: 0x1ACA671 VA: 0x1ACA570
	|-TweenerCore<long, long, NoOptions>.ApplyTween
	|
	|-RVA: 0x1ACBB60 Offset: 0x1ACBC61 VA: 0x1ACBB60
	|-TweenerCore<object, object, NoOptions>.ApplyTween
	|
	|-RVA: 0x1ACD150 Offset: 0x1ACD251 VA: 0x1ACD150
	|-TweenerCore<object, object, StringOptions>.ApplyTween
	|
	|-RVA: 0x1ACE7B0 Offset: 0x1ACE8B1 VA: 0x1ACE7B0
	|-TweenerCore<float, float, FloatOptions>.ApplyTween
	|
	|-RVA: 0x1ACFDB0 Offset: 0x1ACFEB1 VA: 0x1ACFDB0
	|-TweenerCore<uint, uint, UintOptions>.ApplyTween
	|
	|-RVA: 0x1AD13C0 Offset: 0x1AD14C1 VA: 0x1AD13C0
	|-TweenerCore<ulong, ulong, NoOptions>.ApplyTween
	|
	|-RVA: 0x1AD2A80 Offset: 0x1AD2B81 VA: 0x1AD2A80
	|-TweenerCore<Color, Color, ColorOptions>.ApplyTween
	|
	|-RVA: 0x1AD4180 Offset: 0x1AD4281 VA: 0x1AD4180
	|-TweenerCore<Quaternion, Quaternion, NoOptions>.ApplyTween
	|
	|-RVA: 0x1AD5840 Offset: 0x1AD5941 VA: 0x1AD5840
	|-TweenerCore<Quaternion, Vector3, QuaternionOptions>.ApplyTween
	|
	|-RVA: 0x1AD6F70 Offset: 0x1AD7071 VA: 0x1AD6F70
	|-TweenerCore<Rect, Rect, RectOptions>.ApplyTween
	|
	|-RVA: 0x2C81530 Offset: 0x2C81631 VA: 0x2C81530
	|-TweenerCore<Vector2, Vector2, VectorOptions>.ApplyTween
	|
	|-RVA: 0x2C82B30 Offset: 0x2C82C31 VA: 0x2C82B30
	|-TweenerCore<Vector3, object, PathOptions>.ApplyTween
	|
	|-RVA: 0x2C84220 Offset: 0x2C84321 VA: 0x2C84220
	|-TweenerCore<Vector3, object, Vector3ArrayOptions>.ApplyTween
	|
	|-RVA: 0x2C858A0 Offset: 0x2C859A1 VA: 0x2C858A0
	|-TweenerCore<Vector3, Vector3, VectorOptions>.ApplyTween
	|
	|-RVA: 0x2C86F70 Offset: 0x2C87071 VA: 0x2C86F70
	|-TweenerCore<Vector4, Vector4, VectorOptions>.ApplyTween
	*/
}

