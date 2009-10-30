/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Button : Widget {
  private HandleRef swigCPtr;

  internal Button(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.ButtonUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Button obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Button() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        libtischPINVOKE.delete_Button(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Button(int _w, int _h, int _x, int _y, double angle, RGBATexture _tex) : this(libtischPINVOKE.new_Button__SWIG_0(_w, _h, _x, _y, angle, RGBATexture.getCPtr(_tex)), true) {
  }

  public Button(int _w, int _h, int _x, int _y, double angle) : this(libtischPINVOKE.new_Button__SWIG_1(_w, _h, _x, _y, angle), true) {
  }

  public Button(int _w, int _h, int _x, int _y) : this(libtischPINVOKE.new_Button__SWIG_2(_w, _h, _x, _y), true) {
  }

  public Button(int _w, int _h, int _x) : this(libtischPINVOKE.new_Button__SWIG_3(_w, _h, _x), true) {
  }

  public Button(int _w, int _h) : this(libtischPINVOKE.new_Button__SWIG_4(_w, _h), true) {
  }

  public override void draw() {
    libtischPINVOKE.Button_draw(swigCPtr);
  }

  public override void action(Gesture gesture) {
    libtischPINVOKE.Button_action(swigCPtr, Gesture.getCPtr(gesture));
  }

  public virtual void tap(Vector pos, int id) {
    libtischPINVOKE.Button_tap(swigCPtr, Vector.getCPtr(pos), id);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void release() {
    libtischPINVOKE.Button_release(swigCPtr);
  }

}
