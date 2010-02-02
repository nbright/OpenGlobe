﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the Boost Software License, Version 1.0.
// See License.txt or http://www.boost.org/LICENSE_1_0.txt.
//
#endregion

namespace MiniGlobe.Renderer
{
    public class StencilTest
    {
        public StencilTest()
        {
            Enabled = false;
            FrontFace = new StencilTestFace();
            BackFace = new StencilTestFace();
        }

        public bool Enabled { get; set; }
        public StencilTestFace FrontFace { get; set; }
        public StencilTestFace BackFace { get; set; }
    }
}