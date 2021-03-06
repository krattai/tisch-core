/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Container : Tile {
  private HandleRef swigCPtr;

  internal Container(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.ContainerUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Container obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Container() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_Container(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Container(int w, int h, int x, int y, double angle, RGBATexture tex, int mode) : this(libtischPINVOKE.new_Container__SWIG_0(w, h, x, y, angle, libtischPINVOKE.getCPtrAddRef(tex), mode), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Container(int w, int h, int x, int y, double angle, RGBATexture tex) : this(libtischPINVOKE.new_Container__SWIG_1(w, h, x, y, angle, libtischPINVOKE.getCPtrAddRef(tex)), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Container(int w, int h, int x, int y, double angle) : this(libtischPINVOKE.new_Container__SWIG_2(w, h, x, y, angle), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public Container(int w, int h, int x, int y) : this(libtischPINVOKE.new_Container__SWIG_3(w, h, x, y), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public void add(Widget widget, int back) {
    libtischPINVOKE.Container_add__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget), back);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void add(Widget widget) {
    libtischPINVOKE.Container_add__SWIG_1(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void raise(Widget widget) {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_raise__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget)); else libtischPINVOKE.Container_raiseSwigExplicitContainer__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void raise() {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_raise__SWIG_1(swigCPtr); else libtischPINVOKE.Container_raiseSwigExplicitContainer__SWIG_1(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void lower(Widget widget) {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_lower__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget)); else libtischPINVOKE.Container_lowerSwigExplicitContainer__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void lower() {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_lower__SWIG_1(swigCPtr); else libtischPINVOKE.Container_lowerSwigExplicitContainer__SWIG_1(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove(Widget widget, int unreg) {
    libtischPINVOKE.Container_remove__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget), unreg);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove(Widget widget) {
    libtischPINVOKE.Container_remove__SWIG_1(swigCPtr, libtischPINVOKE.getCPtrAddRef(widget));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void draw() {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_draw(swigCPtr); else libtischPINVOKE.Container_drawSwigExplicitContainer(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void paint(bool update_stencil) {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_paint__SWIG_0(swigCPtr, update_stencil); else libtischPINVOKE.Container_paintSwigExplicitContainer__SWIG_0(swigCPtr, update_stencil);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void paint() {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_paint__SWIG_1(swigCPtr); else libtischPINVOKE.Container_paintSwigExplicitContainer__SWIG_1(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void doUpdate(Widget target) {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_doUpdate__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(target)); else libtischPINVOKE.Container_doUpdateSwigExplicitContainer__SWIG_0(swigCPtr, libtischPINVOKE.getCPtrAddRef(target));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void doUpdate() {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_doUpdate__SWIG_1(swigCPtr); else libtischPINVOKE.Container_doUpdateSwigExplicitContainer__SWIG_1(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void tap(Vector vec, int id) {
    if (this.GetType() == typeof(Container)) libtischPINVOKE.Container_tap(swigCPtr, Vector.getCPtr(vec), id); else libtischPINVOKE.Container_tapSwigExplicitContainer(swigCPtr, Vector.getCPtr(vec), id);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  protected int totalHeight() {
    int ret = libtischPINVOKE.Container_totalHeight(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  protected SWIGTYPE_p_std__dequeT_Widget_p_t widgets {
    set {
      libtischPINVOKE.Container_widgets_set(swigCPtr, SWIGTYPE_p_std__dequeT_Widget_p_t.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.Container_widgets_get(swigCPtr);
      SWIGTYPE_p_std__dequeT_Widget_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__dequeT_Widget_p_t(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  protected int locked {
    set {
      libtischPINVOKE.Container_locked_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = libtischPINVOKE.Container_locked_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("outline", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateContainer_0(SwigDirectoroutline);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateContainer_1(SwigDirectorupdate__SWIG_0);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateContainer_2(SwigDirectorupdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateContainer_3(SwigDirectordoUpdate__SWIG_0);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateContainer_4(SwigDirectordoUpdate__SWIG_1);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateContainer_5(SwigDirectorraise__SWIG_0);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateContainer_6(SwigDirectorraise__SWIG_1);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateContainer_7(SwigDirectorlower__SWIG_0);
    if (SwigDerivedClassHasMethod("lower", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateContainer_8(SwigDirectorlower__SWIG_1);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateContainer_9(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("action", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateContainer_10(SwigDirectoraction);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateContainer_11(SwigDirectorenter__SWIG_0);
    if (SwigDerivedClassHasMethod("enter", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateContainer_12(SwigDirectorenter__SWIG_1);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateContainer_13(SwigDirectorpaint__SWIG_0);
    if (SwigDerivedClassHasMethod("paint", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateContainer_14(SwigDirectorpaint__SWIG_1);
    if (SwigDerivedClassHasMethod("tap", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateContainer_15(SwigDirectortap);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateContainer_16(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("apply", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateContainer_17(SwigDirectorapply);
    libtischPINVOKE.Container_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Container));
    return hasDerivedMethod;
  }

  private void SwigDirectoroutline() {
    outline();
  }

  private void SwigDirectorupdate__SWIG_0(IntPtr target) {
    update((target == IntPtr.Zero) ? null : new Widget(target, false));
  }

  private void SwigDirectorupdate__SWIG_1() {
    update();
  }

  private void SwigDirectordoUpdate__SWIG_0(IntPtr target) {
    doUpdate((target == IntPtr.Zero) ? null : new Widget(target, false));
  }

  private void SwigDirectordoUpdate__SWIG_1() {
    doUpdate();
  }

  private void SwigDirectorraise__SWIG_0(IntPtr widget) {
    raise((widget == IntPtr.Zero) ? null : new Widget(widget, false));
  }

  private void SwigDirectorraise__SWIG_1() {
    raise();
  }

  private void SwigDirectorlower__SWIG_0(IntPtr widget) {
    lower((widget == IntPtr.Zero) ? null : new Widget(widget, false));
  }

  private void SwigDirectorlower__SWIG_1() {
    lower();
  }

  private void SwigDirectordraw() {
    draw();
  }

  private void SwigDirectoraction(IntPtr gesture) {
    action((gesture == IntPtr.Zero) ? null : new Gesture(gesture, false));
  }

  private void SwigDirectorenter__SWIG_0(double z) {
    enter(z);
  }

  private void SwigDirectorenter__SWIG_1() {
    enter();
  }

  private void SwigDirectorpaint__SWIG_0(bool update_stencil) {
    paint(update_stencil);
  }

  private void SwigDirectorpaint__SWIG_1() {
    paint();
  }

  private void SwigDirectortap(IntPtr vec, int id) {
    tap(new Vector(vec, false), id);
  }

  private void SwigDirectorrelease() {
    release();
  }

  private void SwigDirectorapply(IntPtr delta) {
    apply(new Vector(delta, false));
  }

  public delegate void SwigDelegateContainer_0();
  public delegate void SwigDelegateContainer_1(IntPtr target);
  public delegate void SwigDelegateContainer_2();
  public delegate void SwigDelegateContainer_3(IntPtr target);
  public delegate void SwigDelegateContainer_4();
  public delegate void SwigDelegateContainer_5(IntPtr widget);
  public delegate void SwigDelegateContainer_6();
  public delegate void SwigDelegateContainer_7(IntPtr widget);
  public delegate void SwigDelegateContainer_8();
  public delegate void SwigDelegateContainer_9();
  public delegate void SwigDelegateContainer_10(IntPtr gesture);
  public delegate void SwigDelegateContainer_11(double z);
  public delegate void SwigDelegateContainer_12();
  public delegate void SwigDelegateContainer_13(bool update_stencil);
  public delegate void SwigDelegateContainer_14();
  public delegate void SwigDelegateContainer_15(IntPtr vec, int id);
  public delegate void SwigDelegateContainer_16();
  public delegate void SwigDelegateContainer_17(IntPtr delta);

  private SwigDelegateContainer_0 swigDelegate0;
  private SwigDelegateContainer_1 swigDelegate1;
  private SwigDelegateContainer_2 swigDelegate2;
  private SwigDelegateContainer_3 swigDelegate3;
  private SwigDelegateContainer_4 swigDelegate4;
  private SwigDelegateContainer_5 swigDelegate5;
  private SwigDelegateContainer_6 swigDelegate6;
  private SwigDelegateContainer_7 swigDelegate7;
  private SwigDelegateContainer_8 swigDelegate8;
  private SwigDelegateContainer_9 swigDelegate9;
  private SwigDelegateContainer_10 swigDelegate10;
  private SwigDelegateContainer_11 swigDelegate11;
  private SwigDelegateContainer_12 swigDelegate12;
  private SwigDelegateContainer_13 swigDelegate13;
  private SwigDelegateContainer_14 swigDelegate14;
  private SwigDelegateContainer_15 swigDelegate15;
  private SwigDelegateContainer_16 swigDelegate16;
  private SwigDelegateContainer_17 swigDelegate17;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes4 = new Type[] {  };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes6 = new Type[] {  };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes8 = new Type[] {  };
  private static Type[] swigMethodTypes9 = new Type[] {  };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(Gesture) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(double) };
  private static Type[] swigMethodTypes12 = new Type[] {  };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(bool) };
  private static Type[] swigMethodTypes14 = new Type[] {  };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(Vector), typeof(int) };
  private static Type[] swigMethodTypes16 = new Type[] {  };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(Vector) };
}
