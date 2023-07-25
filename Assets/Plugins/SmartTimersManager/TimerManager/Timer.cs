﻿using UnityEngine;

        [SerializeField]
        private float m_Interval = 0;
        private bool m_InfiniteLoops = false;

        [SerializeField]
        private UnityEvent m_Event = null;

        private UnityAction m_Delegate = null;

        internal void UpdateActionFromEvent()
        {
            if (m_InfiniteLoops)
                m_LoopsCount = INFINITE;

            if (m_Event != null)
                m_Delegate = delegate { m_Event.Invoke(); };
        }
            {
                m_Interval = 0;
            {
                m_ElapsedTime += Time.deltaTime;
                m_CurrentCycleElapsedTime = m_ElapsedTime - m_CurrentLoopsCount * m_Interval;

                if (m_CurrentCycleElapsedTime > m_Interval)
                {
                    m_CurrentCycleElapsedTime -= m_Interval;
                    m_CurrentLoopsCount++;
                    m_Delegate.Invoke();
                }
        }

        ~Timer()
        {
            m_Delegate = null;
            m_Event = null;
        }

        /// <summary>
        /// Get interval
        /// </summary>

        /// <summary>
        /// Get total loops count (INFINITE (which is uint.MaxValue) if is constantly looping) 
        /// </summary>
        public uint LoopsCount() { return m_LoopsCount; }

        /// <summary>
        /// Get how many loops were completed
        /// </summary>
        public uint CurrentLoopsCount() { return m_CurrentLoopsCount; }
        /// Get how many loops remained to completion
        /// </summary>
        public uint RemainingLoopsCount() { return m_LoopsCount - m_CurrentLoopsCount; }

        /// <summary>
        /// Get total duration, (INFINITE if it's constantly looping)
        /// </summary>

        /// <summary>
        /// Get the delegate to execute
        /// </summary>

        /// <summary>
        /// Get total remaining time
        /// </summary>

        /// <summary>
        /// Get total elapsed time
        /// </summary>
        public float ElapsedTime() { return m_ElapsedTime; }

        /// <summary>
        /// Get elapsed time in current loop
        /// </summary>

        /// <summary>
        /// Get remaining time in current loop
        /// </summary>
        public float CurrentCycleRemainingTime() { return Mathf.Max(m_Interval - m_CurrentCycleElapsedTime, 0); }

        /// <summary>
        /// Checks whether this timer is ok to be removed
        /// </summary>

        /// <summary>
        /// Checks if the timer is paused
        /// </summary>

        /// <summary>
        /// Pause / Inpause timer
        /// </summary>
        

        /// <summary>
        ///     Compare frequency (calls per second)
        /// </summary>
        public static bool operator >(Timer A, Timer B)     { return (A == null || B == null) ? true : A.Interval() < B.Interval(); }

        /// <summary>
        ///     Compare frequency (calls per second)
        /// </summary>

        /// <summary>
        ///     Compare frequency (calls per second)
        /// </summary>

        /// <summary>
        ///     Compare frequency (calls per second)
        /// </summary>