﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace FamilyDay2020_Display
{
    public partial class Form1 : Form
    {
        AnimateImage image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel2.Height = tableLayoutPanel2.Width;
        }

        private void lbl_U_Click(object sender, EventArgs e)
        {

        }

        private void lbl_D_Click(object sender, EventArgs e)
        {

        }

        private void lbl_L_Click(object sender, EventArgs e)
        {

        }

        private void lbl_R_Click(object sender, EventArgs e)
        {

        }

        private void lbl_OK_Click(object sender, EventArgs e)
        {

        }
    }
    public class AnimateImage
    {
        Image image;
        FrameDimension frameDimension;
        /// <summary>   
        /// 动画当前帧发生改变时触发。   
        /// </summary>   
        public event EventHandler<EventArgs> OnFrameChanged;

        /// <summary>   
        /// 实例化一个AnimateImage。   
        /// </summary>   
        /// <param name="img">动画图片。</param>   
        public AnimateImage(Image img)
        {
            image = img;

            lock (image)
            {
                mCanAnimate = ImageAnimator.CanAnimate(image);
                if (mCanAnimate)
                {
                    Guid[] guid = image.FrameDimensionsList;
                    frameDimension = new FrameDimension(guid[0]);
                    mFrameCount = image.GetFrameCount(frameDimension);
                }
            }
        }

        bool mCanAnimate;
        int mFrameCount = 1, mCurrentFrame = 0;

        /// <summary>   
        /// 图片。   
        /// </summary>   
        public Image Image
        {
            get { return image; }
        }

        /// <summary>   
        /// 是否动画。   
        /// </summary>   
        public bool CanAnimate
        {
            get { return mCanAnimate; }
        }

        /// <summary>   
        /// 总帧数。   
        /// </summary>   
        public int FrameCount
        {
            get { return mFrameCount; }
        }

        /// <summary>   
        /// 播放的当前帧。   
        /// </summary>   
        public int CurrentFrame
        {
            get { return mCurrentFrame; }
        }

        /// <summary>   
        /// 播放这个动画。   
        /// </summary>   
        public void Play()
        {
            if (mCanAnimate)
            {
                lock (image)
                {
                    ImageAnimator.Animate(image, new EventHandler(FrameChanged));
                }
            }
        }

        /// <summary>   
        /// 停止播放。   
        /// </summary>   
        public void Stop()
        {
            if (mCanAnimate)
            {
                lock (image)
                {
                    ImageAnimator.StopAnimate(image, new EventHandler(FrameChanged));
                }
            }
        }

        /// <summary>   
        /// 重置动画，使之停止在第0帧位置上。   
        /// </summary>   
        public void Reset()
        {
            if (mCanAnimate)
            {
                ImageAnimator.StopAnimate(image, new EventHandler(FrameChanged));
                lock (image)
                {
                    image.SelectActiveFrame(frameDimension, 0);
                    mCurrentFrame = 0;
                }
            }
        }

        private void FrameChanged(object sender, EventArgs e)
        {
            mCurrentFrame = mCurrentFrame + 1 >= mFrameCount ? 0 : mCurrentFrame + 1;
            lock (image)
            {
                image.SelectActiveFrame(frameDimension, mCurrentFrame);
            }
            if (OnFrameChanged != null)
            {
                OnFrameChanged(image, e);
            }
        }
    }
}
