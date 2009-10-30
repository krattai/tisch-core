/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Widget : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Widget(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Widget obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Widget() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        libtischPINVOKE.delete_Widget(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle, RGBATexture _tex, int _regflags) : this(libtischPINVOKE.new_Widget__SWIG_0(_w, _h, _x, _y, _angle, RGBATexture.getCPtr(_tex), _regflags), true) {
    SwigDirectorConnect();
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle, RGBATexture _tex) : this(libtischPINVOKE.new_Widget__SWIG_1(_w, _h, _x, _y, _angle, RGBATexture.getCPtr(_tex)), true) {
    SwigDirectorConnect();
  }

  public Widget(int _w, int _h, int _x, int _y, double _angle) : this(libtischPINVOKE.new_Widget__SWIG_2(_w, _h, _x, _y, _angle), true) {
    SwigDirectorConnect();
  }

  public Widget(int _w, int _h, int _x, int _y) : this(libtischPINVOKE.new_Widget__SWIG_3(_w, _h, _x, _y), true) {
    SwigDirectorConnect();
  }

  public Widget(int _w, int _h, int _x) : this(libtischPINVOKE.new_Widget__SWIG_4(_w, _h, _x), true) {
    SwigDirectorConnect();
  }

  public Widget(int _w, int _h) : this(libtischPINVOKE.new_Widget__SWIG_5(_w, _h), true) {
    SwigDirectorConnect();
  }

  public Vector glOutline2d(double ox, double oy, int push) {
    Vector ret = new Vector(libtischPINVOKE.Widget_glOutline2d__SWIG_0(swigCPtr, ox, oy, push), true);
    return ret;
  }

  public Vector glOutline2d(double ox, double oy) {
    Vector ret = new Vector(libtischPINVOKE.Widget_glOutline2d__SWIG_1(swigCPtr, ox, oy), true);
    return ret;
  }

  public virtual void outline() {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_outline(swigCPtr); else libtischPINVOKE.Widget_outlineSwigExplicitWidget(swigCPtr);
  }

  public virtual void update(Widget target) {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_update__SWIG_0(swigCPtr, Widget.getCPtr(target)); else libtischPINVOKE.Widget_updateSwigExplicitWidget__SWIG_0(swigCPtr, Widget.getCPtr(target));
  }

  public virtual void update() {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_update__SWIG_1(swigCPtr); else libtischPINVOKE.Widget_updateSwigExplicitWidget__SWIG_1(swigCPtr);
  }

  public virtual void doUpdate(Widget target, SWIGTYPE_p_std__ostream ost) {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_doUpdate__SWIG_0(swigCPtr, Widget.getCPtr(target), SWIGTYPE_p_std__ostream.getCPtr(ost)); else libtischPINVOKE.Widget_doUpdateSwigExplicitWidget__SWIG_0(swigCPtr, Widget.getCPtr(target), SWIGTYPE_p_std__ostream.getCPtr(ost));
  }

  public virtual void doUpdate(Widget target) {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_doUpdate__SWIG_1(swigCPtr, Widget.getCPtr(target)); else libtischPINVOKE.Widget_doUpdateSwigExplicitWidget__SWIG_1(swigCPtr, Widget.getCPtr(target));
  }

  public virtual void doUpdate() {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_doUpdate__SWIG_2(swigCPtr); else libtischPINVOKE.Widget_doUpdateSwigExplicitWidget__SWIG_2(swigCPtr);
  }

  public virtual void raise(Widget widget) {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_raise__SWIG_0(swigCPtr, Widget.getCPtr(widget)); else libtischPINVOKE.Widget_raiseSwigExplicitWidget__SWIG_0(swigCPtr, Widget.getCPtr(widget));
  }

  public virtual void raise() {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_raise__SWIG_1(swigCPtr); else libtischPINVOKE.Widget_raiseSwigExplicitWidget__SWIG_1(swigCPtr);
  }

  public void transform(Vector vec, int abs, int local) {
    libtischPINVOKE.Widget_transform__SWIG_0(swigCPtr, Vector.getCPtr(vec), abs, local);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void transform(Vector vec, int abs) {
    libtischPINVOKE.Widget_transform__SWIG_1(swigCPtr, Vector.getCPtr(vec), abs);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void transform(Vector vec) {
    libtischPINVOKE.Widget_transform__SWIG_2(swigCPtr, Vector.getCPtr(vec));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void texture(RGBATexture tex) {
    libtischPINVOKE.Widget_texture(swigCPtr, RGBATexture.getCPtr(tex));
  }

  public virtual void draw() {
    if (this.GetType() == typeof(Widget)) libtischPINVOKE.Widget_draw(swigCPtr); else libtischPINVOKE.Widget_drawSwigExplicitWidget(swigCPtr);
  }

  public virtual void action(Gesture gesture) {
    libtischPINVOKE.Widget_action(swigCPtr, Gesture.getCPtr(gesture));
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("outline", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateWidget_0(SwigDirectoroutline);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateWidget_1(SwigDirectorupdate__SWIG_0);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateWidget_2(SwigDirectorupdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateWidget_3(SwigDirectordoUpdate__SWIG_0);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateWidget_4(SwigDirectordoUpdate__SWIG_1);
    if (SwigDerivedClassHasMethod("doUpdate", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateWidget_5(SwigDirectordoUpdate__SWIG_2);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateWidget_6(SwigDirectorraise__SWIG_0);
    if (SwigDerivedClassHasMethod("raise", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateWidget_7(SwigDirectorraise__SWIG_1);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateWidget_8(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("action", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateWidget_9(SwigDirectoraction);
    libtischPINVOKE.Widget_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Widget));
    return hasDerivedMethod;
  }

  private void SwigDirectoroutline() {
    outline();
  }

  private void SwigDirectorupdate__SWIG_0(IntPtr target) {
    update(new Widget(target, false));
  }

  private void SwigDirectorupdate__SWIG_1() {
    update();
  }

  private void SwigDirectordoUpdate__SWIG_0(IntPtr target, IntPtr ost) {
    doUpdate(new Widget(target, false), new SWIGTYPE_p_std__ostream(ost, false));
  }

  private void SwigDirectordoUpdate__SWIG_1(IntPtr target) {
    doUpdate(new Widget(target, false));
  }

  private void SwigDirectordoUpdate__SWIG_2() {
    doUpdate();
  }

  private void SwigDirectorraise__SWIG_0(IntPtr widget) {
    raise(new Widget(widget, false));
  }

  private void SwigDirectorraise__SWIG_1() {
    raise();
  }

  private void SwigDirectordraw() {
    draw();
  }

  private void SwigDirectoraction(IntPtr gesture) {
    action(new Gesture(gesture, false));
  }

  public delegate void SwigDelegateWidget_0();
  public delegate void SwigDelegateWidget_1(IntPtr target);
  public delegate void SwigDelegateWidget_2();
  public delegate void SwigDelegateWidget_3(IntPtr target, IntPtr ost);
  public delegate void SwigDelegateWidget_4(IntPtr target);
  public delegate void SwigDelegateWidget_5();
  public delegate void SwigDelegateWidget_6(IntPtr widget);
  public delegate void SwigDelegateWidget_7();
  public delegate void SwigDelegateWidget_8();
  public delegate void SwigDelegateWidget_9(IntPtr gesture);

  private SwigDelegateWidget_0 swigDelegate0;
  private SwigDelegateWidget_1 swigDelegate1;
  private SwigDelegateWidget_2 swigDelegate2;
  private SwigDelegateWidget_3 swigDelegate3;
  private SwigDelegateWidget_4 swigDelegate4;
  private SwigDelegateWidget_5 swigDelegate5;
  private SwigDelegateWidget_6 swigDelegate6;
  private SwigDelegateWidget_7 swigDelegate7;
  private SwigDelegateWidget_8 swigDelegate8;
  private SwigDelegateWidget_9 swigDelegate9;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(Widget), typeof(SWIGTYPE_p_std__ostream) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes5 = new Type[] {  };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(Widget) };
  private static Type[] swigMethodTypes7 = new Type[] {  };
  private static Type[] swigMethodTypes8 = new Type[] {  };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(Gesture) };
}
