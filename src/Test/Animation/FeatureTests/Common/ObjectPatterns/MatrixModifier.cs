// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

//------------------------------------------------------------------

namespace                       Microsoft.Test.Animation.ObjectPatterns
{
    //--------------------------------------------------------------

    /// <summary>
    /// 
    /// </summary>
    public class                MatrixModifier              : System.Windows.Media.Animation.MatrixAnimationBase
    {
        //----------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public                  MatrixModifier ( ModifierController c, double M11, double M12, double M21, double M22, double OffsetX, double OffsetY )
        {
            _controller = c;
            _M11 = M11;
            _M12 = M12;
            _M21 = M21;
            _M22 = M22;
            _OffsetX = OffsetX;
            _OffsetY = OffsetY;
        }

      
        /// <summary>
        /// 
        /// </summary>
        protected MatrixModifier()
        {
        }
       
        //----------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected override void CloneCore(System.Windows.Freezable sourceFreezable)
        {
            MatrixModifier matrixModifier = (MatrixModifier)sourceFreezable;
            base.CloneCore(sourceFreezable);
            _controller = matrixModifier._controller;
            _M11 = matrixModifier._M11;
            _M12 = matrixModifier._M12;
            _M21 = matrixModifier._M21;
            _M22 = matrixModifier._M22;
            _OffsetX = matrixModifier._OffsetX;
            _OffsetY = matrixModifier._OffsetY;

        }
        /// <summary>
        /// 
        /// </summary>
        protected override void GetAsFrozenCore(System.Windows.Freezable sourceFreezable)
        {
            MatrixModifier matrixModifier = (MatrixModifier)sourceFreezable;
            base.GetAsFrozenCore(sourceFreezable);
            _controller = matrixModifier._controller;
            _M11 = matrixModifier._M11;
            _M12 = matrixModifier._M12;
            _M21 = matrixModifier._M21;
            _M22 = matrixModifier._M22;
            _OffsetX = matrixModifier._OffsetX;
            _OffsetY = matrixModifier._OffsetY;

        }
        /// <summary>
        /// 
        /// </summary>
        protected override void GetCurrentValueAsFrozenCore(System.Windows.Freezable sourceFreezable)
        {
            MatrixModifier matrixModifier = (MatrixModifier)sourceFreezable;
            base.GetCurrentValueAsFrozenCore(sourceFreezable);
            _controller = matrixModifier._controller;
            _M11 = matrixModifier._M11;
            _M12 = matrixModifier._M12;
            _M21 = matrixModifier._M21;
            _M22 = matrixModifier._M22;
            _OffsetX = matrixModifier._OffsetX;
            _OffsetY = matrixModifier._OffsetY;

        }
        /// <summary>
        /// 
        /// </summary>
        public new MatrixModifier GetAsFrozen()
        {
            return (MatrixModifier)base.GetAsFrozen();
        }
        /// <summary>
        /// 
        /// </summary>
        protected override System.Windows.Freezable CreateInstanceCore()
        {
            return new MatrixModifier();
        }
     
        /// <summary>
        /// 
        /// </summary>
        protected override System.Windows.Media.Matrix GetCurrentValueCore(System.Windows.Media.Matrix defaultOriginValue, System.Windows.Media.Matrix baseValue, System.Windows.Media.Animation.AnimationClock clock)
        {
            if ( !_controller.UsesBaseValue )
            {
                return new System.Windows.Media.Matrix(_M11, _M12, _M21, _M22, _OffsetX, _OffsetY);
            }
            else
            {
                return new System.Windows.Media.Matrix (baseValue.M11 + _M11, baseValue.M12 + _M12,
                baseValue.M21 + _M21, baseValue.M22 + _M22, baseValue.OffsetX + _OffsetX, baseValue.OffsetY + _OffsetY);
            }
        }

        //----------------------------------------------------------

        private ModifierController  _controller;
        private double _M11;
        private double _M12;
        private double _M21;
        private double _M22;
        private double _OffsetX;
        private double _OffsetY;
    }
}