﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the Boost Software License, Version 1.0.
// See License.txt or http://www.boost.org/LICENSE_1_0.txt.
//
#endregion

using OpenTK;
using OpenTK.Graphics.OpenGL;
using MiniGlobe.Renderer;

namespace MiniGlobe.Renderer.GL32
{
    internal class UniformFloatVector3GL32 : Uniform<Vector3>, ICleanable
    {
        internal UniformFloatVector3GL32(int programHandle, string name, int location)
            : base(name, location, UniformType.FloatVector3)
        {
            float[] initialValue = new float[3];
            GL.GetUniform(programHandle, location, initialValue);
            _value = new Vector3(initialValue[0], initialValue[1], initialValue[2]);
        }

        #region ICleanable Uniform<>

        public override Vector3 Value
        {
            set
            {
                if (_value != value)
                {
                    _value = value;
                    _dirty = true;
                }
            }

            get { return _value; }
        }

        #endregion

        #region ICleanable Members

        public void Clean()
        {
            if (_dirty)
            {
                GL.Uniform3(Location, _value);
                _dirty = false;
            }
        }

        #endregion

        private Vector3 _value;
        private bool _dirty;
    }
}