﻿using System;

namespace Core
{
    public abstract class Task
    {
        private Action _callback;
        
        public void Run(Action callback)
        {
            _callback = callback;

            OnRun();
        }
        
        protected abstract void OnRun();

        protected void Finish()
        {
            if (_callback != null)
            {
                var cachedCallback = _callback;
                _callback = null;
                
                cachedCallback?.Invoke();
            }
            
            OnFinish();
        }
        
        protected virtual void OnFinish() {}
    }
}