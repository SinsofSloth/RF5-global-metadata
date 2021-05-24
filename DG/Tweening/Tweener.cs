public abstract class Tweener : Tween // TypeDefIndex: 5015
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x120
	internal bool isFromAllowed; // 0x121

	// Methods

	// RVA: 0x1B95160 Offset: 0x1B95261 VA: 0x1B95160
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative) { }

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517060 Offset: 0x2517161 VA: 0x2517060
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2517250 Offset: 0x2517351 VA: 0x2517250
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x2517410 Offset: 0x2517511 VA: 0x2517410
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x25175E0 Offset: 0x25176E1 VA: 0x25175E0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x25177B0 Offset: 0x25178B1 VA: 0x25177B0
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x2517980 Offset: 0x2517A81 VA: 0x2517980
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x2517B50 Offset: 0x2517C51 VA: 0x2517B50
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x2517D10 Offset: 0x2517E11 VA: 0x2517D10
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x2517EE0 Offset: 0x2517FE1 VA: 0x2517EE0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x25180B0 Offset: 0x25181B1 VA: 0x25180B0
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x25182A0 Offset: 0x25183A1 VA: 0x25182A0
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2518490 Offset: 0x2518591 VA: 0x2518490
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2518670 Offset: 0x2518771 VA: 0x2518670
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2518860 Offset: 0x2518961 VA: 0x2518860
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x2518A30 Offset: 0x2518B31 VA: 0x2518A30
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2518DD0 Offset: 0x2518ED1 VA: 0x2518DD0
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2518FB0 Offset: 0x25190B1 VA: 0x2518FB0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561D20 Offset: 0x2561E21 VA: 0x2561D20
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2561D60 Offset: 0x2561E61 VA: 0x2561D60
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x2561DA0 Offset: 0x2561EA1 VA: 0x2561DA0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x2561DE0 Offset: 0x2561EE1 VA: 0x2561DE0
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x2561E20 Offset: 0x2561F21 VA: 0x2561E20
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x2561E60 Offset: 0x2561F61 VA: 0x2561E60
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x2561EA0 Offset: 0x2561FA1 VA: 0x2561EA0
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x2561EE0 Offset: 0x2561FE1 VA: 0x2561EE0
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x2561F20 Offset: 0x2562021 VA: 0x2561F20
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2561F60 Offset: 0x2562061 VA: 0x2561F60
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x2561FA0 Offset: 0x25620A1 VA: 0x2561FA0
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2561FE0 Offset: 0x25620E1 VA: 0x2561FE0
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2562020 Offset: 0x2562121 VA: 0x2562020
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2562060 Offset: 0x2562161 VA: 0x2562060
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25620A0 Offset: 0x25621A1 VA: 0x25620A0
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x25620E0 Offset: 0x25621E1 VA: 0x25620E0
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2562120 Offset: 0x2562221 VA: 0x2562120
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2562160 Offset: 0x2562261 VA: 0x2562160
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F1F0 Offset: 0x281F2F1 VA: 0x281F1F0
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281F570 Offset: 0x281F671 VA: 0x281F570
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x281F890 Offset: 0x281F991 VA: 0x281F890
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x281FBB0 Offset: 0x281FCB1 VA: 0x281FBB0
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x281FED0 Offset: 0x281FFD1 VA: 0x281FED0
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x2820200 Offset: 0x2820301 VA: 0x2820200
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x2820530 Offset: 0x2820631 VA: 0x2820530
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x2820850 Offset: 0x2820951 VA: 0x2820850
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x2820B70 Offset: 0x2820C71 VA: 0x2820B70
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2820E90 Offset: 0x2820F91 VA: 0x2820E90
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x28211B0 Offset: 0x28212B1 VA: 0x28211B0
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x28214D0 Offset: 0x28215D1 VA: 0x28214D0
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x28217E0 Offset: 0x28218E1 VA: 0x28217E0
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x25160D0 Offset: 0x25161D1 VA: 0x25160D0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25163F0 Offset: 0x25164F1 VA: 0x25163F0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2516710 Offset: 0x2516811 VA: 0x2516710
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2516A30 Offset: 0x2516B31 VA: 0x2516A30
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2516D40 Offset: 0x2516E41 VA: 0x2516D40
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB69F0 Offset: 0x1AB6AF1 VA: 0x1AB69F0
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB6AE0 Offset: 0x1AB6BE1 VA: 0x1AB6AE0
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB6C80 Offset: 0x1AB6D81 VA: 0x1AB6C80
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB6D50 Offset: 0x1AB6E51 VA: 0x1AB6D50
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB6E30 Offset: 0x1AB6F31 VA: 0x1AB6E30
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB6F10 Offset: 0x1AB7011 VA: 0x1AB6F10
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB70B0 Offset: 0x1AB71B1 VA: 0x1AB70B0
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB7180 Offset: 0x1AB7281 VA: 0x1AB7180
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB7260 Offset: 0x1AB7361 VA: 0x1AB7260
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB7340 Offset: 0x1AB7441 VA: 0x1AB7340
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB7420 Offset: 0x1AB7521 VA: 0x1AB7420
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB7500 Offset: 0x1AB7601 VA: 0x1AB7500
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB75D0 Offset: 0x1AB76D1 VA: 0x1AB75D0
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB76B0 Offset: 0x1AB77B1 VA: 0x1AB76B0
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB7790 Offset: 0x1AB7891 VA: 0x1AB7790
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB7870 Offset: 0x1AB7971 VA: 0x1AB7870
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB37E0 Offset: 0x1AB38E1 VA: 0x1AB37E0
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB3B40 Offset: 0x1AB3C41 VA: 0x1AB3B40
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB3DE0 Offset: 0x1AB3EE1 VA: 0x1AB3DE0
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB4090 Offset: 0x1AB4191 VA: 0x1AB4090
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB4340 Offset: 0x1AB4441 VA: 0x1AB4340
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB4610 Offset: 0x1AB4711 VA: 0x1AB4610
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB48E0 Offset: 0x1AB49E1 VA: 0x1AB48E0
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB4B80 Offset: 0x1AB4C81 VA: 0x1AB4B80
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB4E30 Offset: 0x1AB4F31 VA: 0x1AB4E30
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB50E0 Offset: 0x1AB51E1 VA: 0x1AB50E0
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB53B0 Offset: 0x1AB54B1 VA: 0x1AB53B0
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB5680 Offset: 0x1AB5781 VA: 0x1AB5680
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB5940 Offset: 0x1AB5A41 VA: 0x1AB5940
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB5C10 Offset: 0x1AB5D11 VA: 0x1AB5C10
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB5EC0 Offset: 0x1AB5FC1 VA: 0x1AB5EC0
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB6190 Offset: 0x1AB6291 VA: 0x1AB6190
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB6460 Offset: 0x1AB6561 VA: 0x1AB6460
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB6720 Offset: 0x1AB6821 VA: 0x1AB6720
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB7950 Offset: 0x1AB7A51 VA: 0x1AB7950
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB7A70 Offset: 0x1AB7B71 VA: 0x1AB7A70
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x1AB7B50 Offset: 0x1AB7C51 VA: 0x1AB7B50
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x1AB7C30 Offset: 0x1AB7D31 VA: 0x1AB7C30
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x1AB7D10 Offset: 0x1AB7E11 VA: 0x1AB7D10
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x1AB7E10 Offset: 0x1AB7F11 VA: 0x1AB7E10
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x1AB7F10 Offset: 0x1AB8011 VA: 0x1AB7F10
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x1AB7FF0 Offset: 0x1AB80F1 VA: 0x1AB7FF0
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB80D0 Offset: 0x1AB81D1 VA: 0x1AB80D0
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB81B0 Offset: 0x1AB82B1 VA: 0x1AB81B0
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB82B0 Offset: 0x1AB83B1 VA: 0x1AB82B0
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB83B0 Offset: 0x1AB84B1 VA: 0x1AB83B0
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB84A0 Offset: 0x1AB85A1 VA: 0x1AB84A0
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB85A0 Offset: 0x1AB86A1 VA: 0x1AB85A0
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB8680 Offset: 0x1AB8781 VA: 0x1AB8680
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB8780 Offset: 0x1AB8881 VA: 0x1AB8780
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB8880 Offset: 0x1AB8981 VA: 0x1AB8880
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB8970 Offset: 0x1AB8A71 VA: 0x1AB8970
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281CCD0 Offset: 0x281CDD1 VA: 0x281CCD0
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281CEE0 Offset: 0x281CFE1 VA: 0x281CEE0
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x281D0F0 Offset: 0x281D1F1 VA: 0x281D0F0
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x281D300 Offset: 0x281D401 VA: 0x281D300
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x281D510 Offset: 0x281D611 VA: 0x281D510
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x281D930 Offset: 0x281DA31 VA: 0x281D930
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x281DB40 Offset: 0x281DC41 VA: 0x281DB40
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x281DD50 Offset: 0x281DE51 VA: 0x281DD50
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x281DF60 Offset: 0x281E061 VA: 0x281DF60
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x281E170 Offset: 0x281E271 VA: 0x281E170
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x281E380 Offset: 0x281E481 VA: 0x281E380
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x281E590 Offset: 0x281E691 VA: 0x281E590
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x281E7A0 Offset: 0x281E8A1 VA: 0x281E7A0
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x281E9B0 Offset: 0x281EAB1 VA: 0x281E9B0
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x281EBC0 Offset: 0x281ECC1 VA: 0x281EBC0
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x281EDD0 Offset: 0x281EED1 VA: 0x281EDD0
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x281EFE0 Offset: 0x281F0E1 VA: 0x281EFE0
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CF010 Offset: 0x21CF111 VA: 0x21CF010
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x21CF0D0 Offset: 0x21CF1D1 VA: 0x21CF0D0
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x21CF150 Offset: 0x21CF251 VA: 0x21CF150
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x21CF1D0 Offset: 0x21CF2D1 VA: 0x21CF1D0
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x21CF250 Offset: 0x21CF351 VA: 0x21CF250
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x21CF2D0 Offset: 0x21CF3D1 VA: 0x21CF2D0
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x21CF370 Offset: 0x21CF471 VA: 0x21CF370
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x21CF3F0 Offset: 0x21CF4F1 VA: 0x21CF3F0
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x21CF470 Offset: 0x21CF571 VA: 0x21CF470
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x21CF4F0 Offset: 0x21CF5F1 VA: 0x21CF4F0
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x21CF580 Offset: 0x21CF681 VA: 0x21CF580
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x21CF610 Offset: 0x21CF711 VA: 0x21CF610
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x21CF750 Offset: 0x21CF851 VA: 0x21CF750
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x21CF7E0 Offset: 0x21CF8E1 VA: 0x21CF7E0
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x21CF8D0 Offset: 0x21CF9D1 VA: 0x21CF8D0
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x21CF950 Offset: 0x21CFA51 VA: 0x21CF950
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x21CF9E0 Offset: 0x21CFAE1 VA: 0x21CF9E0
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	*/
}

public abstract class Tweener : Tween // TypeDefIndex: 5015
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x120
	internal bool isFromAllowed; // 0x121

	// Methods

	// RVA: 0x1B95160 Offset: 0x1B95261 VA: 0x1B95160
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative) { }

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517060 Offset: 0x2517161 VA: 0x2517060
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2517250 Offset: 0x2517351 VA: 0x2517250
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x2517410 Offset: 0x2517511 VA: 0x2517410
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x25175E0 Offset: 0x25176E1 VA: 0x25175E0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x25177B0 Offset: 0x25178B1 VA: 0x25177B0
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x2517980 Offset: 0x2517A81 VA: 0x2517980
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x2517B50 Offset: 0x2517C51 VA: 0x2517B50
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x2517D10 Offset: 0x2517E11 VA: 0x2517D10
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x2517EE0 Offset: 0x2517FE1 VA: 0x2517EE0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x25180B0 Offset: 0x25181B1 VA: 0x25180B0
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x25182A0 Offset: 0x25183A1 VA: 0x25182A0
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2518490 Offset: 0x2518591 VA: 0x2518490
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2518670 Offset: 0x2518771 VA: 0x2518670
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2518860 Offset: 0x2518961 VA: 0x2518860
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x2518A30 Offset: 0x2518B31 VA: 0x2518A30
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2518DD0 Offset: 0x2518ED1 VA: 0x2518DD0
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2518FB0 Offset: 0x25190B1 VA: 0x2518FB0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561D20 Offset: 0x2561E21 VA: 0x2561D20
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2561D60 Offset: 0x2561E61 VA: 0x2561D60
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x2561DA0 Offset: 0x2561EA1 VA: 0x2561DA0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x2561DE0 Offset: 0x2561EE1 VA: 0x2561DE0
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x2561E20 Offset: 0x2561F21 VA: 0x2561E20
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x2561E60 Offset: 0x2561F61 VA: 0x2561E60
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x2561EA0 Offset: 0x2561FA1 VA: 0x2561EA0
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x2561EE0 Offset: 0x2561FE1 VA: 0x2561EE0
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x2561F20 Offset: 0x2562021 VA: 0x2561F20
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2561F60 Offset: 0x2562061 VA: 0x2561F60
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x2561FA0 Offset: 0x25620A1 VA: 0x2561FA0
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2561FE0 Offset: 0x25620E1 VA: 0x2561FE0
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2562020 Offset: 0x2562121 VA: 0x2562020
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2562060 Offset: 0x2562161 VA: 0x2562060
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25620A0 Offset: 0x25621A1 VA: 0x25620A0
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x25620E0 Offset: 0x25621E1 VA: 0x25620E0
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2562120 Offset: 0x2562221 VA: 0x2562120
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2562160 Offset: 0x2562261 VA: 0x2562160
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F1F0 Offset: 0x281F2F1 VA: 0x281F1F0
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281F570 Offset: 0x281F671 VA: 0x281F570
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x281F890 Offset: 0x281F991 VA: 0x281F890
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x281FBB0 Offset: 0x281FCB1 VA: 0x281FBB0
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x281FED0 Offset: 0x281FFD1 VA: 0x281FED0
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x2820200 Offset: 0x2820301 VA: 0x2820200
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x2820530 Offset: 0x2820631 VA: 0x2820530
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x2820850 Offset: 0x2820951 VA: 0x2820850
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x2820B70 Offset: 0x2820C71 VA: 0x2820B70
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2820E90 Offset: 0x2820F91 VA: 0x2820E90
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x28211B0 Offset: 0x28212B1 VA: 0x28211B0
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x28214D0 Offset: 0x28215D1 VA: 0x28214D0
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x28217E0 Offset: 0x28218E1 VA: 0x28217E0
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x25160D0 Offset: 0x25161D1 VA: 0x25160D0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25163F0 Offset: 0x25164F1 VA: 0x25163F0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2516710 Offset: 0x2516811 VA: 0x2516710
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2516A30 Offset: 0x2516B31 VA: 0x2516A30
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2516D40 Offset: 0x2516E41 VA: 0x2516D40
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB69F0 Offset: 0x1AB6AF1 VA: 0x1AB69F0
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB6AE0 Offset: 0x1AB6BE1 VA: 0x1AB6AE0
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB6C80 Offset: 0x1AB6D81 VA: 0x1AB6C80
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB6D50 Offset: 0x1AB6E51 VA: 0x1AB6D50
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB6E30 Offset: 0x1AB6F31 VA: 0x1AB6E30
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB6F10 Offset: 0x1AB7011 VA: 0x1AB6F10
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB70B0 Offset: 0x1AB71B1 VA: 0x1AB70B0
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB7180 Offset: 0x1AB7281 VA: 0x1AB7180
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB7260 Offset: 0x1AB7361 VA: 0x1AB7260
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB7340 Offset: 0x1AB7441 VA: 0x1AB7340
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB7420 Offset: 0x1AB7521 VA: 0x1AB7420
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB7500 Offset: 0x1AB7601 VA: 0x1AB7500
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB75D0 Offset: 0x1AB76D1 VA: 0x1AB75D0
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB76B0 Offset: 0x1AB77B1 VA: 0x1AB76B0
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB7790 Offset: 0x1AB7891 VA: 0x1AB7790
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB7870 Offset: 0x1AB7971 VA: 0x1AB7870
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB37E0 Offset: 0x1AB38E1 VA: 0x1AB37E0
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB3B40 Offset: 0x1AB3C41 VA: 0x1AB3B40
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB3DE0 Offset: 0x1AB3EE1 VA: 0x1AB3DE0
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB4090 Offset: 0x1AB4191 VA: 0x1AB4090
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB4340 Offset: 0x1AB4441 VA: 0x1AB4340
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB4610 Offset: 0x1AB4711 VA: 0x1AB4610
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB48E0 Offset: 0x1AB49E1 VA: 0x1AB48E0
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB4B80 Offset: 0x1AB4C81 VA: 0x1AB4B80
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB4E30 Offset: 0x1AB4F31 VA: 0x1AB4E30
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB50E0 Offset: 0x1AB51E1 VA: 0x1AB50E0
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB53B0 Offset: 0x1AB54B1 VA: 0x1AB53B0
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB5680 Offset: 0x1AB5781 VA: 0x1AB5680
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB5940 Offset: 0x1AB5A41 VA: 0x1AB5940
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB5C10 Offset: 0x1AB5D11 VA: 0x1AB5C10
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB5EC0 Offset: 0x1AB5FC1 VA: 0x1AB5EC0
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB6190 Offset: 0x1AB6291 VA: 0x1AB6190
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB6460 Offset: 0x1AB6561 VA: 0x1AB6460
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB6720 Offset: 0x1AB6821 VA: 0x1AB6720
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB7950 Offset: 0x1AB7A51 VA: 0x1AB7950
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB7A70 Offset: 0x1AB7B71 VA: 0x1AB7A70
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x1AB7B50 Offset: 0x1AB7C51 VA: 0x1AB7B50
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x1AB7C30 Offset: 0x1AB7D31 VA: 0x1AB7C30
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x1AB7D10 Offset: 0x1AB7E11 VA: 0x1AB7D10
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x1AB7E10 Offset: 0x1AB7F11 VA: 0x1AB7E10
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x1AB7F10 Offset: 0x1AB8011 VA: 0x1AB7F10
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x1AB7FF0 Offset: 0x1AB80F1 VA: 0x1AB7FF0
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB80D0 Offset: 0x1AB81D1 VA: 0x1AB80D0
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB81B0 Offset: 0x1AB82B1 VA: 0x1AB81B0
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB82B0 Offset: 0x1AB83B1 VA: 0x1AB82B0
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB83B0 Offset: 0x1AB84B1 VA: 0x1AB83B0
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB84A0 Offset: 0x1AB85A1 VA: 0x1AB84A0
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB85A0 Offset: 0x1AB86A1 VA: 0x1AB85A0
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB8680 Offset: 0x1AB8781 VA: 0x1AB8680
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB8780 Offset: 0x1AB8881 VA: 0x1AB8780
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB8880 Offset: 0x1AB8981 VA: 0x1AB8880
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB8970 Offset: 0x1AB8A71 VA: 0x1AB8970
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281CCD0 Offset: 0x281CDD1 VA: 0x281CCD0
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281CEE0 Offset: 0x281CFE1 VA: 0x281CEE0
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x281D0F0 Offset: 0x281D1F1 VA: 0x281D0F0
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x281D300 Offset: 0x281D401 VA: 0x281D300
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x281D510 Offset: 0x281D611 VA: 0x281D510
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x281D930 Offset: 0x281DA31 VA: 0x281D930
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x281DB40 Offset: 0x281DC41 VA: 0x281DB40
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x281DD50 Offset: 0x281DE51 VA: 0x281DD50
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x281DF60 Offset: 0x281E061 VA: 0x281DF60
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x281E170 Offset: 0x281E271 VA: 0x281E170
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x281E380 Offset: 0x281E481 VA: 0x281E380
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x281E590 Offset: 0x281E691 VA: 0x281E590
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x281E7A0 Offset: 0x281E8A1 VA: 0x281E7A0
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x281E9B0 Offset: 0x281EAB1 VA: 0x281E9B0
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x281EBC0 Offset: 0x281ECC1 VA: 0x281EBC0
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x281EDD0 Offset: 0x281EED1 VA: 0x281EDD0
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x281EFE0 Offset: 0x281F0E1 VA: 0x281EFE0
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CF010 Offset: 0x21CF111 VA: 0x21CF010
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x21CF0D0 Offset: 0x21CF1D1 VA: 0x21CF0D0
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x21CF150 Offset: 0x21CF251 VA: 0x21CF150
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x21CF1D0 Offset: 0x21CF2D1 VA: 0x21CF1D0
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x21CF250 Offset: 0x21CF351 VA: 0x21CF250
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x21CF2D0 Offset: 0x21CF3D1 VA: 0x21CF2D0
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x21CF370 Offset: 0x21CF471 VA: 0x21CF370
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x21CF3F0 Offset: 0x21CF4F1 VA: 0x21CF3F0
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x21CF470 Offset: 0x21CF571 VA: 0x21CF470
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x21CF4F0 Offset: 0x21CF5F1 VA: 0x21CF4F0
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x21CF580 Offset: 0x21CF681 VA: 0x21CF580
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x21CF610 Offset: 0x21CF711 VA: 0x21CF610
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x21CF750 Offset: 0x21CF851 VA: 0x21CF750
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x21CF7E0 Offset: 0x21CF8E1 VA: 0x21CF7E0
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x21CF8D0 Offset: 0x21CF9D1 VA: 0x21CF8D0
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x21CF950 Offset: 0x21CFA51 VA: 0x21CF950
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x21CF9E0 Offset: 0x21CFAE1 VA: 0x21CF9E0
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	*/
}

public abstract class Tweener : Tween // TypeDefIndex: 5015
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x120
	internal bool isFromAllowed; // 0x121

	// Methods

	// RVA: 0x1B95160 Offset: 0x1B95261 VA: 0x1B95160
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative) { }

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517060 Offset: 0x2517161 VA: 0x2517060
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2517250 Offset: 0x2517351 VA: 0x2517250
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x2517410 Offset: 0x2517511 VA: 0x2517410
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x25175E0 Offset: 0x25176E1 VA: 0x25175E0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x25177B0 Offset: 0x25178B1 VA: 0x25177B0
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x2517980 Offset: 0x2517A81 VA: 0x2517980
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x2517B50 Offset: 0x2517C51 VA: 0x2517B50
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x2517D10 Offset: 0x2517E11 VA: 0x2517D10
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x2517EE0 Offset: 0x2517FE1 VA: 0x2517EE0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x25180B0 Offset: 0x25181B1 VA: 0x25180B0
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x25182A0 Offset: 0x25183A1 VA: 0x25182A0
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2518490 Offset: 0x2518591 VA: 0x2518490
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2518670 Offset: 0x2518771 VA: 0x2518670
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2518860 Offset: 0x2518961 VA: 0x2518860
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x2518A30 Offset: 0x2518B31 VA: 0x2518A30
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2518DD0 Offset: 0x2518ED1 VA: 0x2518DD0
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2518FB0 Offset: 0x25190B1 VA: 0x2518FB0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561D20 Offset: 0x2561E21 VA: 0x2561D20
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2561D60 Offset: 0x2561E61 VA: 0x2561D60
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x2561DA0 Offset: 0x2561EA1 VA: 0x2561DA0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x2561DE0 Offset: 0x2561EE1 VA: 0x2561DE0
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x2561E20 Offset: 0x2561F21 VA: 0x2561E20
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x2561E60 Offset: 0x2561F61 VA: 0x2561E60
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x2561EA0 Offset: 0x2561FA1 VA: 0x2561EA0
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x2561EE0 Offset: 0x2561FE1 VA: 0x2561EE0
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x2561F20 Offset: 0x2562021 VA: 0x2561F20
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2561F60 Offset: 0x2562061 VA: 0x2561F60
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x2561FA0 Offset: 0x25620A1 VA: 0x2561FA0
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2561FE0 Offset: 0x25620E1 VA: 0x2561FE0
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2562020 Offset: 0x2562121 VA: 0x2562020
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2562060 Offset: 0x2562161 VA: 0x2562060
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25620A0 Offset: 0x25621A1 VA: 0x25620A0
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x25620E0 Offset: 0x25621E1 VA: 0x25620E0
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2562120 Offset: 0x2562221 VA: 0x2562120
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2562160 Offset: 0x2562261 VA: 0x2562160
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F1F0 Offset: 0x281F2F1 VA: 0x281F1F0
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281F570 Offset: 0x281F671 VA: 0x281F570
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x281F890 Offset: 0x281F991 VA: 0x281F890
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x281FBB0 Offset: 0x281FCB1 VA: 0x281FBB0
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x281FED0 Offset: 0x281FFD1 VA: 0x281FED0
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x2820200 Offset: 0x2820301 VA: 0x2820200
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x2820530 Offset: 0x2820631 VA: 0x2820530
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x2820850 Offset: 0x2820951 VA: 0x2820850
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x2820B70 Offset: 0x2820C71 VA: 0x2820B70
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2820E90 Offset: 0x2820F91 VA: 0x2820E90
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x28211B0 Offset: 0x28212B1 VA: 0x28211B0
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x28214D0 Offset: 0x28215D1 VA: 0x28214D0
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x28217E0 Offset: 0x28218E1 VA: 0x28217E0
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x25160D0 Offset: 0x25161D1 VA: 0x25160D0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25163F0 Offset: 0x25164F1 VA: 0x25163F0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2516710 Offset: 0x2516811 VA: 0x2516710
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2516A30 Offset: 0x2516B31 VA: 0x2516A30
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2516D40 Offset: 0x2516E41 VA: 0x2516D40
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB69F0 Offset: 0x1AB6AF1 VA: 0x1AB69F0
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB6AE0 Offset: 0x1AB6BE1 VA: 0x1AB6AE0
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB6C80 Offset: 0x1AB6D81 VA: 0x1AB6C80
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB6D50 Offset: 0x1AB6E51 VA: 0x1AB6D50
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB6E30 Offset: 0x1AB6F31 VA: 0x1AB6E30
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB6F10 Offset: 0x1AB7011 VA: 0x1AB6F10
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB70B0 Offset: 0x1AB71B1 VA: 0x1AB70B0
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB7180 Offset: 0x1AB7281 VA: 0x1AB7180
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB7260 Offset: 0x1AB7361 VA: 0x1AB7260
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB7340 Offset: 0x1AB7441 VA: 0x1AB7340
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB7420 Offset: 0x1AB7521 VA: 0x1AB7420
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB7500 Offset: 0x1AB7601 VA: 0x1AB7500
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB75D0 Offset: 0x1AB76D1 VA: 0x1AB75D0
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB76B0 Offset: 0x1AB77B1 VA: 0x1AB76B0
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB7790 Offset: 0x1AB7891 VA: 0x1AB7790
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB7870 Offset: 0x1AB7971 VA: 0x1AB7870
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB37E0 Offset: 0x1AB38E1 VA: 0x1AB37E0
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB3B40 Offset: 0x1AB3C41 VA: 0x1AB3B40
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB3DE0 Offset: 0x1AB3EE1 VA: 0x1AB3DE0
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB4090 Offset: 0x1AB4191 VA: 0x1AB4090
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB4340 Offset: 0x1AB4441 VA: 0x1AB4340
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB4610 Offset: 0x1AB4711 VA: 0x1AB4610
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB48E0 Offset: 0x1AB49E1 VA: 0x1AB48E0
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB4B80 Offset: 0x1AB4C81 VA: 0x1AB4B80
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB4E30 Offset: 0x1AB4F31 VA: 0x1AB4E30
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB50E0 Offset: 0x1AB51E1 VA: 0x1AB50E0
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB53B0 Offset: 0x1AB54B1 VA: 0x1AB53B0
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB5680 Offset: 0x1AB5781 VA: 0x1AB5680
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB5940 Offset: 0x1AB5A41 VA: 0x1AB5940
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB5C10 Offset: 0x1AB5D11 VA: 0x1AB5C10
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB5EC0 Offset: 0x1AB5FC1 VA: 0x1AB5EC0
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB6190 Offset: 0x1AB6291 VA: 0x1AB6190
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB6460 Offset: 0x1AB6561 VA: 0x1AB6460
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB6720 Offset: 0x1AB6821 VA: 0x1AB6720
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB7950 Offset: 0x1AB7A51 VA: 0x1AB7950
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB7A70 Offset: 0x1AB7B71 VA: 0x1AB7A70
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x1AB7B50 Offset: 0x1AB7C51 VA: 0x1AB7B50
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x1AB7C30 Offset: 0x1AB7D31 VA: 0x1AB7C30
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x1AB7D10 Offset: 0x1AB7E11 VA: 0x1AB7D10
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x1AB7E10 Offset: 0x1AB7F11 VA: 0x1AB7E10
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x1AB7F10 Offset: 0x1AB8011 VA: 0x1AB7F10
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x1AB7FF0 Offset: 0x1AB80F1 VA: 0x1AB7FF0
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB80D0 Offset: 0x1AB81D1 VA: 0x1AB80D0
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB81B0 Offset: 0x1AB82B1 VA: 0x1AB81B0
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB82B0 Offset: 0x1AB83B1 VA: 0x1AB82B0
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB83B0 Offset: 0x1AB84B1 VA: 0x1AB83B0
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB84A0 Offset: 0x1AB85A1 VA: 0x1AB84A0
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB85A0 Offset: 0x1AB86A1 VA: 0x1AB85A0
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB8680 Offset: 0x1AB8781 VA: 0x1AB8680
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB8780 Offset: 0x1AB8881 VA: 0x1AB8780
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB8880 Offset: 0x1AB8981 VA: 0x1AB8880
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB8970 Offset: 0x1AB8A71 VA: 0x1AB8970
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281CCD0 Offset: 0x281CDD1 VA: 0x281CCD0
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281CEE0 Offset: 0x281CFE1 VA: 0x281CEE0
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x281D0F0 Offset: 0x281D1F1 VA: 0x281D0F0
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x281D300 Offset: 0x281D401 VA: 0x281D300
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x281D510 Offset: 0x281D611 VA: 0x281D510
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x281D930 Offset: 0x281DA31 VA: 0x281D930
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x281DB40 Offset: 0x281DC41 VA: 0x281DB40
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x281DD50 Offset: 0x281DE51 VA: 0x281DD50
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x281DF60 Offset: 0x281E061 VA: 0x281DF60
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x281E170 Offset: 0x281E271 VA: 0x281E170
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x281E380 Offset: 0x281E481 VA: 0x281E380
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x281E590 Offset: 0x281E691 VA: 0x281E590
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x281E7A0 Offset: 0x281E8A1 VA: 0x281E7A0
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x281E9B0 Offset: 0x281EAB1 VA: 0x281E9B0
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x281EBC0 Offset: 0x281ECC1 VA: 0x281EBC0
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x281EDD0 Offset: 0x281EED1 VA: 0x281EDD0
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x281EFE0 Offset: 0x281F0E1 VA: 0x281EFE0
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CF010 Offset: 0x21CF111 VA: 0x21CF010
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x21CF0D0 Offset: 0x21CF1D1 VA: 0x21CF0D0
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x21CF150 Offset: 0x21CF251 VA: 0x21CF150
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x21CF1D0 Offset: 0x21CF2D1 VA: 0x21CF1D0
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x21CF250 Offset: 0x21CF351 VA: 0x21CF250
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x21CF2D0 Offset: 0x21CF3D1 VA: 0x21CF2D0
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x21CF370 Offset: 0x21CF471 VA: 0x21CF370
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x21CF3F0 Offset: 0x21CF4F1 VA: 0x21CF3F0
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x21CF470 Offset: 0x21CF571 VA: 0x21CF470
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x21CF4F0 Offset: 0x21CF5F1 VA: 0x21CF4F0
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x21CF580 Offset: 0x21CF681 VA: 0x21CF580
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x21CF610 Offset: 0x21CF711 VA: 0x21CF610
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x21CF750 Offset: 0x21CF851 VA: 0x21CF750
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x21CF7E0 Offset: 0x21CF8E1 VA: 0x21CF7E0
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x21CF8D0 Offset: 0x21CF9D1 VA: 0x21CF8D0
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x21CF950 Offset: 0x21CFA51 VA: 0x21CF950
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x21CF9E0 Offset: 0x21CFAE1 VA: 0x21CF9E0
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	*/
}

public abstract class Tweener : Tween // TypeDefIndex: 5015
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x120
	internal bool isFromAllowed; // 0x121

	// Methods

	// RVA: 0x1B95160 Offset: 0x1B95261 VA: 0x1B95160
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative) { }

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517060 Offset: 0x2517161 VA: 0x2517060
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2517250 Offset: 0x2517351 VA: 0x2517250
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x2517410 Offset: 0x2517511 VA: 0x2517410
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x25175E0 Offset: 0x25176E1 VA: 0x25175E0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x25177B0 Offset: 0x25178B1 VA: 0x25177B0
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x2517980 Offset: 0x2517A81 VA: 0x2517980
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x2517B50 Offset: 0x2517C51 VA: 0x2517B50
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x2517D10 Offset: 0x2517E11 VA: 0x2517D10
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x2517EE0 Offset: 0x2517FE1 VA: 0x2517EE0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x25180B0 Offset: 0x25181B1 VA: 0x25180B0
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x25182A0 Offset: 0x25183A1 VA: 0x25182A0
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2518490 Offset: 0x2518591 VA: 0x2518490
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2518670 Offset: 0x2518771 VA: 0x2518670
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2518860 Offset: 0x2518961 VA: 0x2518860
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x2518A30 Offset: 0x2518B31 VA: 0x2518A30
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2518DD0 Offset: 0x2518ED1 VA: 0x2518DD0
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2518FB0 Offset: 0x25190B1 VA: 0x2518FB0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561D20 Offset: 0x2561E21 VA: 0x2561D20
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2561D60 Offset: 0x2561E61 VA: 0x2561D60
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x2561DA0 Offset: 0x2561EA1 VA: 0x2561DA0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x2561DE0 Offset: 0x2561EE1 VA: 0x2561DE0
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x2561E20 Offset: 0x2561F21 VA: 0x2561E20
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x2561E60 Offset: 0x2561F61 VA: 0x2561E60
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x2561EA0 Offset: 0x2561FA1 VA: 0x2561EA0
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x2561EE0 Offset: 0x2561FE1 VA: 0x2561EE0
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x2561F20 Offset: 0x2562021 VA: 0x2561F20
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2561F60 Offset: 0x2562061 VA: 0x2561F60
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x2561FA0 Offset: 0x25620A1 VA: 0x2561FA0
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2561FE0 Offset: 0x25620E1 VA: 0x2561FE0
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2562020 Offset: 0x2562121 VA: 0x2562020
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2562060 Offset: 0x2562161 VA: 0x2562060
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25620A0 Offset: 0x25621A1 VA: 0x25620A0
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x25620E0 Offset: 0x25621E1 VA: 0x25620E0
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2562120 Offset: 0x2562221 VA: 0x2562120
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2562160 Offset: 0x2562261 VA: 0x2562160
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F1F0 Offset: 0x281F2F1 VA: 0x281F1F0
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281F570 Offset: 0x281F671 VA: 0x281F570
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x281F890 Offset: 0x281F991 VA: 0x281F890
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x281FBB0 Offset: 0x281FCB1 VA: 0x281FBB0
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x281FED0 Offset: 0x281FFD1 VA: 0x281FED0
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x2820200 Offset: 0x2820301 VA: 0x2820200
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x2820530 Offset: 0x2820631 VA: 0x2820530
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x2820850 Offset: 0x2820951 VA: 0x2820850
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x2820B70 Offset: 0x2820C71 VA: 0x2820B70
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2820E90 Offset: 0x2820F91 VA: 0x2820E90
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x28211B0 Offset: 0x28212B1 VA: 0x28211B0
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x28214D0 Offset: 0x28215D1 VA: 0x28214D0
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x28217E0 Offset: 0x28218E1 VA: 0x28217E0
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x25160D0 Offset: 0x25161D1 VA: 0x25160D0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25163F0 Offset: 0x25164F1 VA: 0x25163F0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2516710 Offset: 0x2516811 VA: 0x2516710
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2516A30 Offset: 0x2516B31 VA: 0x2516A30
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2516D40 Offset: 0x2516E41 VA: 0x2516D40
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB69F0 Offset: 0x1AB6AF1 VA: 0x1AB69F0
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB6AE0 Offset: 0x1AB6BE1 VA: 0x1AB6AE0
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB6C80 Offset: 0x1AB6D81 VA: 0x1AB6C80
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB6D50 Offset: 0x1AB6E51 VA: 0x1AB6D50
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB6E30 Offset: 0x1AB6F31 VA: 0x1AB6E30
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB6F10 Offset: 0x1AB7011 VA: 0x1AB6F10
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB70B0 Offset: 0x1AB71B1 VA: 0x1AB70B0
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB7180 Offset: 0x1AB7281 VA: 0x1AB7180
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB7260 Offset: 0x1AB7361 VA: 0x1AB7260
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB7340 Offset: 0x1AB7441 VA: 0x1AB7340
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB7420 Offset: 0x1AB7521 VA: 0x1AB7420
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB7500 Offset: 0x1AB7601 VA: 0x1AB7500
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB75D0 Offset: 0x1AB76D1 VA: 0x1AB75D0
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB76B0 Offset: 0x1AB77B1 VA: 0x1AB76B0
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB7790 Offset: 0x1AB7891 VA: 0x1AB7790
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB7870 Offset: 0x1AB7971 VA: 0x1AB7870
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB37E0 Offset: 0x1AB38E1 VA: 0x1AB37E0
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB3B40 Offset: 0x1AB3C41 VA: 0x1AB3B40
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB3DE0 Offset: 0x1AB3EE1 VA: 0x1AB3DE0
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB4090 Offset: 0x1AB4191 VA: 0x1AB4090
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB4340 Offset: 0x1AB4441 VA: 0x1AB4340
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB4610 Offset: 0x1AB4711 VA: 0x1AB4610
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB48E0 Offset: 0x1AB49E1 VA: 0x1AB48E0
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB4B80 Offset: 0x1AB4C81 VA: 0x1AB4B80
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB4E30 Offset: 0x1AB4F31 VA: 0x1AB4E30
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB50E0 Offset: 0x1AB51E1 VA: 0x1AB50E0
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB53B0 Offset: 0x1AB54B1 VA: 0x1AB53B0
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB5680 Offset: 0x1AB5781 VA: 0x1AB5680
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB5940 Offset: 0x1AB5A41 VA: 0x1AB5940
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB5C10 Offset: 0x1AB5D11 VA: 0x1AB5C10
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB5EC0 Offset: 0x1AB5FC1 VA: 0x1AB5EC0
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB6190 Offset: 0x1AB6291 VA: 0x1AB6190
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB6460 Offset: 0x1AB6561 VA: 0x1AB6460
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB6720 Offset: 0x1AB6821 VA: 0x1AB6720
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB7950 Offset: 0x1AB7A51 VA: 0x1AB7950
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB7A70 Offset: 0x1AB7B71 VA: 0x1AB7A70
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x1AB7B50 Offset: 0x1AB7C51 VA: 0x1AB7B50
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x1AB7C30 Offset: 0x1AB7D31 VA: 0x1AB7C30
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x1AB7D10 Offset: 0x1AB7E11 VA: 0x1AB7D10
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x1AB7E10 Offset: 0x1AB7F11 VA: 0x1AB7E10
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x1AB7F10 Offset: 0x1AB8011 VA: 0x1AB7F10
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x1AB7FF0 Offset: 0x1AB80F1 VA: 0x1AB7FF0
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB80D0 Offset: 0x1AB81D1 VA: 0x1AB80D0
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB81B0 Offset: 0x1AB82B1 VA: 0x1AB81B0
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB82B0 Offset: 0x1AB83B1 VA: 0x1AB82B0
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB83B0 Offset: 0x1AB84B1 VA: 0x1AB83B0
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB84A0 Offset: 0x1AB85A1 VA: 0x1AB84A0
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB85A0 Offset: 0x1AB86A1 VA: 0x1AB85A0
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB8680 Offset: 0x1AB8781 VA: 0x1AB8680
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB8780 Offset: 0x1AB8881 VA: 0x1AB8780
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB8880 Offset: 0x1AB8981 VA: 0x1AB8880
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB8970 Offset: 0x1AB8A71 VA: 0x1AB8970
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281CCD0 Offset: 0x281CDD1 VA: 0x281CCD0
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281CEE0 Offset: 0x281CFE1 VA: 0x281CEE0
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x281D0F0 Offset: 0x281D1F1 VA: 0x281D0F0
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x281D300 Offset: 0x281D401 VA: 0x281D300
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x281D510 Offset: 0x281D611 VA: 0x281D510
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x281D930 Offset: 0x281DA31 VA: 0x281D930
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x281DB40 Offset: 0x281DC41 VA: 0x281DB40
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x281DD50 Offset: 0x281DE51 VA: 0x281DD50
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x281DF60 Offset: 0x281E061 VA: 0x281DF60
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x281E170 Offset: 0x281E271 VA: 0x281E170
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x281E380 Offset: 0x281E481 VA: 0x281E380
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x281E590 Offset: 0x281E691 VA: 0x281E590
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x281E7A0 Offset: 0x281E8A1 VA: 0x281E7A0
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x281E9B0 Offset: 0x281EAB1 VA: 0x281E9B0
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x281EBC0 Offset: 0x281ECC1 VA: 0x281EBC0
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x281EDD0 Offset: 0x281EED1 VA: 0x281EDD0
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x281EFE0 Offset: 0x281F0E1 VA: 0x281EFE0
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CF010 Offset: 0x21CF111 VA: 0x21CF010
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x21CF0D0 Offset: 0x21CF1D1 VA: 0x21CF0D0
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x21CF150 Offset: 0x21CF251 VA: 0x21CF150
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x21CF1D0 Offset: 0x21CF2D1 VA: 0x21CF1D0
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x21CF250 Offset: 0x21CF351 VA: 0x21CF250
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x21CF2D0 Offset: 0x21CF3D1 VA: 0x21CF2D0
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x21CF370 Offset: 0x21CF471 VA: 0x21CF370
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x21CF3F0 Offset: 0x21CF4F1 VA: 0x21CF3F0
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x21CF470 Offset: 0x21CF571 VA: 0x21CF470
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x21CF4F0 Offset: 0x21CF5F1 VA: 0x21CF4F0
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x21CF580 Offset: 0x21CF681 VA: 0x21CF580
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x21CF610 Offset: 0x21CF711 VA: 0x21CF610
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x21CF750 Offset: 0x21CF851 VA: 0x21CF750
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x21CF7E0 Offset: 0x21CF8E1 VA: 0x21CF7E0
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x21CF8D0 Offset: 0x21CF9D1 VA: 0x21CF8D0
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x21CF950 Offset: 0x21CFA51 VA: 0x21CF950
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x21CF9E0 Offset: 0x21CFAE1 VA: 0x21CF9E0
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	*/
}

public abstract class Tweener : Tween // TypeDefIndex: 5015
{
	// Fields
	internal bool hasManuallySetStartValue; // 0x120
	internal bool isFromAllowed; // 0x121

	// Methods

	// RVA: 0x1B95160 Offset: 0x1B95261 VA: 0x1B95160
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Tweener ChangeStartValue(object newStartValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Tweener ChangeEndValue(object newEndValue, float newDuration = -1, bool snapStartValue = False) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Tweener ChangeEndValue(object newEndValue, bool snapStartValue) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Tweener SetFrom(bool relative) { }

	// RVA: -1 Offset: -1
	internal static bool Setup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517060 Offset: 0x2517161 VA: 0x2517060
	|-Tweener.Setup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2517250 Offset: 0x2517351 VA: 0x2517250
	|-Tweener.Setup<double, double, NoOptions>
	|
	|-RVA: 0x2517410 Offset: 0x2517511 VA: 0x2517410
	|-Tweener.Setup<int, int, NoOptions>
	|
	|-RVA: 0x25175E0 Offset: 0x25176E1 VA: 0x25175E0
	|-Tweener.Setup<long, long, NoOptions>
	|
	|-RVA: 0x25177B0 Offset: 0x25178B1 VA: 0x25177B0
	|-Tweener.Setup<object, object, NoOptions>
	|
	|-RVA: 0x2517980 Offset: 0x2517A81 VA: 0x2517980
	|-Tweener.Setup<object, object, StringOptions>
	|
	|-RVA: 0x2517B50 Offset: 0x2517C51 VA: 0x2517B50
	|-Tweener.Setup<float, float, FloatOptions>
	|
	|-RVA: 0x2517D10 Offset: 0x2517E11 VA: 0x2517D10
	|-Tweener.Setup<uint, uint, UintOptions>
	|
	|-RVA: 0x2517EE0 Offset: 0x2517FE1 VA: 0x2517EE0
	|-Tweener.Setup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x25180B0 Offset: 0x25181B1 VA: 0x25180B0
	|-Tweener.Setup<Color, Color, ColorOptions>
	|
	|-RVA: 0x25182A0 Offset: 0x25183A1 VA: 0x25182A0
	|-Tweener.Setup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2518490 Offset: 0x2518591 VA: 0x2518490
	|-Tweener.Setup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2518670 Offset: 0x2518771 VA: 0x2518670
	|-Tweener.Setup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2518860 Offset: 0x2518961 VA: 0x2518860
	|-Tweener.Setup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x2518A30 Offset: 0x2518B31 VA: 0x2518A30
	|-Tweener.Setup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-Tweener.Setup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2518DD0 Offset: 0x2518ED1 VA: 0x2518DD0
	|-Tweener.Setup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2518FB0 Offset: 0x25190B1 VA: 0x2518FB0
	|-Tweener.Setup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static float DoUpdateDelay<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, float elapsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561D20 Offset: 0x2561E21 VA: 0x2561D20
	|-Tweener.DoUpdateDelay<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x2561D60 Offset: 0x2561E61 VA: 0x2561D60
	|-Tweener.DoUpdateDelay<double, double, NoOptions>
	|
	|-RVA: 0x2561DA0 Offset: 0x2561EA1 VA: 0x2561DA0
	|-Tweener.DoUpdateDelay<int, int, NoOptions>
	|
	|-RVA: 0x2561DE0 Offset: 0x2561EE1 VA: 0x2561DE0
	|-Tweener.DoUpdateDelay<long, long, NoOptions>
	|
	|-RVA: 0x2561E20 Offset: 0x2561F21 VA: 0x2561E20
	|-Tweener.DoUpdateDelay<object, object, NoOptions>
	|
	|-RVA: 0x2561E60 Offset: 0x2561F61 VA: 0x2561E60
	|-Tweener.DoUpdateDelay<object, object, StringOptions>
	|
	|-RVA: 0x2561EA0 Offset: 0x2561FA1 VA: 0x2561EA0
	|-Tweener.DoUpdateDelay<float, float, FloatOptions>
	|
	|-RVA: 0x2561EE0 Offset: 0x2561FE1 VA: 0x2561EE0
	|-Tweener.DoUpdateDelay<uint, uint, UintOptions>
	|
	|-RVA: 0x2561F20 Offset: 0x2562021 VA: 0x2561F20
	|-Tweener.DoUpdateDelay<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2561F60 Offset: 0x2562061 VA: 0x2561F60
	|-Tweener.DoUpdateDelay<Color, Color, ColorOptions>
	|
	|-RVA: 0x2561FA0 Offset: 0x25620A1 VA: 0x2561FA0
	|-Tweener.DoUpdateDelay<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x2561FE0 Offset: 0x25620E1 VA: 0x2561FE0
	|-Tweener.DoUpdateDelay<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x2562020 Offset: 0x2562121 VA: 0x2562020
	|-Tweener.DoUpdateDelay<Rect, Rect, RectOptions>
	|
	|-RVA: 0x2562060 Offset: 0x2562161 VA: 0x2562060
	|-Tweener.DoUpdateDelay<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25620A0 Offset: 0x25621A1 VA: 0x25620A0
	|-Tweener.DoUpdateDelay<Vector3, object, PathOptions>
	|
	|-RVA: 0x25620E0 Offset: 0x25621E1 VA: 0x25620E0
	|-Tweener.DoUpdateDelay<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2562120 Offset: 0x2562221 VA: 0x2562120
	|-Tweener.DoUpdateDelay<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2562160 Offset: 0x2562261 VA: 0x2562160
	|-Tweener.DoUpdateDelay<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static bool DoStartup<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281F1F0 Offset: 0x281F2F1 VA: 0x281F1F0
	|-Tweener.DoStartup<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281F570 Offset: 0x281F671 VA: 0x281F570
	|-Tweener.DoStartup<double, double, NoOptions>
	|
	|-RVA: 0x281F890 Offset: 0x281F991 VA: 0x281F890
	|-Tweener.DoStartup<int, int, NoOptions>
	|
	|-RVA: 0x281FBB0 Offset: 0x281FCB1 VA: 0x281FBB0
	|-Tweener.DoStartup<long, long, NoOptions>
	|
	|-RVA: 0x281FED0 Offset: 0x281FFD1 VA: 0x281FED0
	|-Tweener.DoStartup<object, object, NoOptions>
	|
	|-RVA: 0x2820200 Offset: 0x2820301 VA: 0x2820200
	|-Tweener.DoStartup<object, object, StringOptions>
	|
	|-RVA: 0x2820530 Offset: 0x2820631 VA: 0x2820530
	|-Tweener.DoStartup<float, float, FloatOptions>
	|
	|-RVA: 0x2820850 Offset: 0x2820951 VA: 0x2820850
	|-Tweener.DoStartup<uint, uint, UintOptions>
	|
	|-RVA: 0x2820B70 Offset: 0x2820C71 VA: 0x2820B70
	|-Tweener.DoStartup<ulong, ulong, NoOptions>
	|
	|-RVA: 0x2820E90 Offset: 0x2820F91 VA: 0x2820E90
	|-Tweener.DoStartup<Color, Color, ColorOptions>
	|
	|-RVA: 0x28211B0 Offset: 0x28212B1 VA: 0x28211B0
	|-Tweener.DoStartup<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x28214D0 Offset: 0x28215D1 VA: 0x28214D0
	|-Tweener.DoStartup<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x28217E0 Offset: 0x28218E1 VA: 0x28217E0
	|-Tweener.DoStartup<Rect, Rect, RectOptions>
	|
	|-RVA: 0x25160D0 Offset: 0x25161D1 VA: 0x25160D0
	|-Tweener.DoStartup<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x25163F0 Offset: 0x25164F1 VA: 0x25163F0
	|-Tweener.DoStartup<Vector3, object, PathOptions>
	|
	|-RVA: 0x2516710 Offset: 0x2516811 VA: 0x2516710
	|-Tweener.DoStartup<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x2516A30 Offset: 0x2516B31 VA: 0x2516A30
	|-Tweener.DoStartup<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x2516D40 Offset: 0x2516E41 VA: 0x2516D40
	|-Tweener.DoStartup<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB69F0 Offset: 0x1AB6AF1 VA: 0x1AB69F0
	|-Tweener.DoChangeStartValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB6AE0 Offset: 0x1AB6BE1 VA: 0x1AB6AE0
	|-Tweener.DoChangeStartValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0
	|-Tweener.DoChangeStartValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB6C80 Offset: 0x1AB6D81 VA: 0x1AB6C80
	|-Tweener.DoChangeStartValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB6D50 Offset: 0x1AB6E51 VA: 0x1AB6D50
	|-Tweener.DoChangeStartValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB6E30 Offset: 0x1AB6F31 VA: 0x1AB6E30
	|-Tweener.DoChangeStartValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB6F10 Offset: 0x1AB7011 VA: 0x1AB6F10
	|-Tweener.DoChangeStartValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	|-Tweener.DoChangeStartValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB70B0 Offset: 0x1AB71B1 VA: 0x1AB70B0
	|-Tweener.DoChangeStartValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB7180 Offset: 0x1AB7281 VA: 0x1AB7180
	|-Tweener.DoChangeStartValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB7260 Offset: 0x1AB7361 VA: 0x1AB7260
	|-Tweener.DoChangeStartValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB7340 Offset: 0x1AB7441 VA: 0x1AB7340
	|-Tweener.DoChangeStartValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB7420 Offset: 0x1AB7521 VA: 0x1AB7420
	|-Tweener.DoChangeStartValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB7500 Offset: 0x1AB7601 VA: 0x1AB7500
	|-Tweener.DoChangeStartValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB75D0 Offset: 0x1AB76D1 VA: 0x1AB75D0
	|-Tweener.DoChangeStartValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB76B0 Offset: 0x1AB77B1 VA: 0x1AB76B0
	|-Tweener.DoChangeStartValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB7790 Offset: 0x1AB7891 VA: 0x1AB7790
	|-Tweener.DoChangeStartValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB7870 Offset: 0x1AB7971 VA: 0x1AB7870
	|-Tweener.DoChangeStartValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB37E0 Offset: 0x1AB38E1 VA: 0x1AB37E0
	|-Tweener.DoChangeEndValue<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB3B40 Offset: 0x1AB3C41 VA: 0x1AB3B40
	|-Tweener.DoChangeEndValue<double, double, NoOptions>
	|
	|-RVA: 0x1AB3DE0 Offset: 0x1AB3EE1 VA: 0x1AB3DE0
	|-Tweener.DoChangeEndValue<int, int, NoOptions>
	|
	|-RVA: 0x1AB4090 Offset: 0x1AB4191 VA: 0x1AB4090
	|-Tweener.DoChangeEndValue<long, long, NoOptions>
	|
	|-RVA: 0x1AB4340 Offset: 0x1AB4441 VA: 0x1AB4340
	|-Tweener.DoChangeEndValue<object, object, NoOptions>
	|
	|-RVA: 0x1AB4610 Offset: 0x1AB4711 VA: 0x1AB4610
	|-Tweener.DoChangeEndValue<object, object, StringOptions>
	|
	|-RVA: 0x1AB48E0 Offset: 0x1AB49E1 VA: 0x1AB48E0
	|-Tweener.DoChangeEndValue<float, float, FloatOptions>
	|
	|-RVA: 0x1AB4B80 Offset: 0x1AB4C81 VA: 0x1AB4B80
	|-Tweener.DoChangeEndValue<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB4E30 Offset: 0x1AB4F31 VA: 0x1AB4E30
	|-Tweener.DoChangeEndValue<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB50E0 Offset: 0x1AB51E1 VA: 0x1AB50E0
	|-Tweener.DoChangeEndValue<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB53B0 Offset: 0x1AB54B1 VA: 0x1AB53B0
	|-Tweener.DoChangeEndValue<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB5680 Offset: 0x1AB5781 VA: 0x1AB5680
	|-Tweener.DoChangeEndValue<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB5940 Offset: 0x1AB5A41 VA: 0x1AB5940
	|-Tweener.DoChangeEndValue<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB5C10 Offset: 0x1AB5D11 VA: 0x1AB5C10
	|-Tweener.DoChangeEndValue<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB5EC0 Offset: 0x1AB5FC1 VA: 0x1AB5EC0
	|-Tweener.DoChangeEndValue<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB6190 Offset: 0x1AB6291 VA: 0x1AB6190
	|-Tweener.DoChangeEndValue<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB6460 Offset: 0x1AB6561 VA: 0x1AB6460
	|-Tweener.DoChangeEndValue<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB6720 Offset: 0x1AB6821 VA: 0x1AB6720
	|-Tweener.DoChangeEndValue<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB7950 Offset: 0x1AB7A51 VA: 0x1AB7950
	|-Tweener.DoChangeValues<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB7A70 Offset: 0x1AB7B71 VA: 0x1AB7A70
	|-Tweener.DoChangeValues<double, double, NoOptions>
	|
	|-RVA: 0x1AB7B50 Offset: 0x1AB7C51 VA: 0x1AB7B50
	|-Tweener.DoChangeValues<int, int, NoOptions>
	|
	|-RVA: 0x1AB7C30 Offset: 0x1AB7D31 VA: 0x1AB7C30
	|-Tweener.DoChangeValues<long, long, NoOptions>
	|
	|-RVA: 0x1AB7D10 Offset: 0x1AB7E11 VA: 0x1AB7D10
	|-Tweener.DoChangeValues<object, object, NoOptions>
	|
	|-RVA: 0x1AB7E10 Offset: 0x1AB7F11 VA: 0x1AB7E10
	|-Tweener.DoChangeValues<object, object, StringOptions>
	|
	|-RVA: 0x1AB7F10 Offset: 0x1AB8011 VA: 0x1AB7F10
	|-Tweener.DoChangeValues<float, float, FloatOptions>
	|
	|-RVA: 0x1AB7FF0 Offset: 0x1AB80F1 VA: 0x1AB7FF0
	|-Tweener.DoChangeValues<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB80D0 Offset: 0x1AB81D1 VA: 0x1AB80D0
	|-Tweener.DoChangeValues<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB81B0 Offset: 0x1AB82B1 VA: 0x1AB81B0
	|-Tweener.DoChangeValues<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB82B0 Offset: 0x1AB83B1 VA: 0x1AB82B0
	|-Tweener.DoChangeValues<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB83B0 Offset: 0x1AB84B1 VA: 0x1AB83B0
	|-Tweener.DoChangeValues<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB84A0 Offset: 0x1AB85A1 VA: 0x1AB84A0
	|-Tweener.DoChangeValues<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB85A0 Offset: 0x1AB86A1 VA: 0x1AB85A0
	|-Tweener.DoChangeValues<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB8680 Offset: 0x1AB8781 VA: 0x1AB8680
	|-Tweener.DoChangeValues<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB8780 Offset: 0x1AB8881 VA: 0x1AB8780
	|-Tweener.DoChangeValues<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB8880 Offset: 0x1AB8981 VA: 0x1AB8880
	|-Tweener.DoChangeValues<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB8970 Offset: 0x1AB8A71 VA: 0x1AB8970
	|-Tweener.DoChangeValues<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static bool DOStartupSpecials<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281CCD0 Offset: 0x281CDD1 VA: 0x281CCD0
	|-Tweener.DOStartupSpecials<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x281CEE0 Offset: 0x281CFE1 VA: 0x281CEE0
	|-Tweener.DOStartupSpecials<double, double, NoOptions>
	|
	|-RVA: 0x281D0F0 Offset: 0x281D1F1 VA: 0x281D0F0
	|-Tweener.DOStartupSpecials<int, int, NoOptions>
	|
	|-RVA: 0x281D300 Offset: 0x281D401 VA: 0x281D300
	|-Tweener.DOStartupSpecials<long, long, NoOptions>
	|
	|-RVA: 0x281D510 Offset: 0x281D611 VA: 0x281D510
	|-Tweener.DOStartupSpecials<object, object, NoOptions>
	|
	|-RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	|-Tweener.DOStartupSpecials<object, object, StringOptions>
	|
	|-RVA: 0x281D930 Offset: 0x281DA31 VA: 0x281D930
	|-Tweener.DOStartupSpecials<float, float, FloatOptions>
	|
	|-RVA: 0x281DB40 Offset: 0x281DC41 VA: 0x281DB40
	|-Tweener.DOStartupSpecials<uint, uint, UintOptions>
	|
	|-RVA: 0x281DD50 Offset: 0x281DE51 VA: 0x281DD50
	|-Tweener.DOStartupSpecials<ulong, ulong, NoOptions>
	|
	|-RVA: 0x281DF60 Offset: 0x281E061 VA: 0x281DF60
	|-Tweener.DOStartupSpecials<Color, Color, ColorOptions>
	|
	|-RVA: 0x281E170 Offset: 0x281E271 VA: 0x281E170
	|-Tweener.DOStartupSpecials<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x281E380 Offset: 0x281E481 VA: 0x281E380
	|-Tweener.DOStartupSpecials<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x281E590 Offset: 0x281E691 VA: 0x281E590
	|-Tweener.DOStartupSpecials<Rect, Rect, RectOptions>
	|
	|-RVA: 0x281E7A0 Offset: 0x281E8A1 VA: 0x281E7A0
	|-Tweener.DOStartupSpecials<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x281E9B0 Offset: 0x281EAB1 VA: 0x281E9B0
	|-Tweener.DOStartupSpecials<Vector3, object, PathOptions>
	|
	|-RVA: 0x281EBC0 Offset: 0x281ECC1 VA: 0x281EBC0
	|-Tweener.DOStartupSpecials<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x281EDD0 Offset: 0x281EED1 VA: 0x281EDD0
	|-Tweener.DOStartupSpecials<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x281EFE0 Offset: 0x281F0E1 VA: 0x281EFE0
	|-Tweener.DOStartupSpecials<Vector4, Vector4, VectorOptions>
	*/

	// RVA: -1 Offset: -1
	private static void DOStartupDurationBased<T1, T2, TPlugOptions>(TweenerCore<T1, T2, TPlugOptions> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CF010 Offset: 0x21CF111 VA: 0x21CF010
	|-Tweener.DOStartupDurationBased<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x21CF0D0 Offset: 0x21CF1D1 VA: 0x21CF0D0
	|-Tweener.DOStartupDurationBased<double, double, NoOptions>
	|
	|-RVA: 0x21CF150 Offset: 0x21CF251 VA: 0x21CF150
	|-Tweener.DOStartupDurationBased<int, int, NoOptions>
	|
	|-RVA: 0x21CF1D0 Offset: 0x21CF2D1 VA: 0x21CF1D0
	|-Tweener.DOStartupDurationBased<long, long, NoOptions>
	|
	|-RVA: 0x21CF250 Offset: 0x21CF351 VA: 0x21CF250
	|-Tweener.DOStartupDurationBased<object, object, NoOptions>
	|
	|-RVA: 0x21CF2D0 Offset: 0x21CF3D1 VA: 0x21CF2D0
	|-Tweener.DOStartupDurationBased<object, object, StringOptions>
	|
	|-RVA: 0x21CF370 Offset: 0x21CF471 VA: 0x21CF370
	|-Tweener.DOStartupDurationBased<float, float, FloatOptions>
	|
	|-RVA: 0x21CF3F0 Offset: 0x21CF4F1 VA: 0x21CF3F0
	|-Tweener.DOStartupDurationBased<uint, uint, UintOptions>
	|
	|-RVA: 0x21CF470 Offset: 0x21CF571 VA: 0x21CF470
	|-Tweener.DOStartupDurationBased<ulong, ulong, NoOptions>
	|
	|-RVA: 0x21CF4F0 Offset: 0x21CF5F1 VA: 0x21CF4F0
	|-Tweener.DOStartupDurationBased<Color, Color, ColorOptions>
	|
	|-RVA: 0x21CF580 Offset: 0x21CF681 VA: 0x21CF580
	|-Tweener.DOStartupDurationBased<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x21CF610 Offset: 0x21CF711 VA: 0x21CF610
	|-Tweener.DOStartupDurationBased<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	|-Tweener.DOStartupDurationBased<Rect, Rect, RectOptions>
	|
	|-RVA: 0x21CF750 Offset: 0x21CF851 VA: 0x21CF750
	|-Tweener.DOStartupDurationBased<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x21CF7E0 Offset: 0x21CF8E1 VA: 0x21CF7E0
	|-Tweener.DOStartupDurationBased<Vector3, object, PathOptions>
	|
	|-RVA: 0x21CF8D0 Offset: 0x21CF9D1 VA: 0x21CF8D0
	|-Tweener.DOStartupDurationBased<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x21CF950 Offset: 0x21CFA51 VA: 0x21CF950
	|-Tweener.DOStartupDurationBased<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x21CF9E0 Offset: 0x21CFAE1 VA: 0x21CF9E0
	|-Tweener.DOStartupDurationBased<Vector4, Vector4, VectorOptions>
	*/
}

