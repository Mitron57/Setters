﻿using System.Runtime.CompilerServices;
using Platform.Interfaces;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents a range between minumum and maximum values.</para>
    /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
    /// </summary>
    /// <remarks>
    /// Must be class, not struct (in order to persist access to Result property value).
    /// </remarks>
    public abstract class SetterBase<TResult> : ISetter<TResult>
    {
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        protected TResult _result;
        
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        public TResult Result => _result;
        
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase() { }
    
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected SetterBase(TResult defaultValue) => _result = defaultValue;
        
        /// <summary>
        /// <para>Represents a range between minumum and maximum values.</para>
        /// <para>Представляет диапазон между минимальным и максимальным значениями.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(TResult value) => _result = value;
    }
}
