﻿using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI;
using Windows.Foundation;
using System.Diagnostics;

namespace CsConsumer
{
    class GeometryTestScene
    {
        //
        // Factored into a separate file for readability.
        // This test renders a number of geometry primitives using basic drawing functions.
        // 
        public enum RenderingType { Default, Wireframe }

        class TestSceneRenderer // Used to abstract out a wireframe view.
        {
            public TestSceneRenderer(CanvasDrawingSession drawingSession, RenderingType renderingType)
            {
                m_drawingSession = drawingSession;
                m_renderingType = renderingType;
                Debug.Assert(m_renderingType == RenderingType.Default || m_renderingType == RenderingType.Wireframe);
            }
            public void Clear(Color color)
            {
                if (m_renderingType == RenderingType.Default)
                {
                    m_drawingSession.Clear(color);
                }
                else
                {
                    m_drawingSession.Clear(Colors.White);
                }
            }

            public void FillRectangle(Rect rect, CanvasSolidColorBrush brush)
            {
                if (m_renderingType == RenderingType.Default)
                {
                    m_drawingSession.FillRectangle(rect, brush);
                }
                else
                {
                    brush.Color = Colors.Black;
                    m_drawingSession.DrawRectangle(rect, brush);
                }
            }
            public void DrawLine(Point p1, Point p2, CanvasSolidColorBrush brush, float strokeWidth)
            {
                if (m_renderingType == RenderingType.Default)
                {
                    m_drawingSession.DrawLine(p1, p2, brush, strokeWidth);
                }
                else
                {
                    brush.Color = Colors.Black;
                    m_drawingSession.DrawLine(p1, p2, brush);
                }
            }
            public void FillEllipse(CanvasEllipse ellipse, CanvasSolidColorBrush brush)
            {
                if (m_renderingType == RenderingType.Default)
                {
                    m_drawingSession.FillEllipse(ellipse, brush);
                }
                else
                {
                    brush.Color = Colors.Black;
                    m_drawingSession.DrawEllipse(ellipse, brush);
                }
            }

            CanvasDrawingSession m_drawingSession;
            RenderingType m_renderingType;
        }
        
        public static void DrawGeometryTestScene(CanvasDrawingSession drawingSession, CanvasSolidColorBrush brush, RenderingType renderingType)
        {
            //
            // The geometry in this function was produced using external tooling, then fitted to suit
            // Canvas drawing operations. Dimensions are around 1200x1200.
            //

            TestSceneRenderer sceneRenderer = new TestSceneRenderer(drawingSession, renderingType);

            sceneRenderer.Clear(Color.FromArgb(0xFF,112, 107, 103));
            
            brush.Color = Color.FromArgb(0xFF, 0xA6, 0xC7, 0x46);
            sceneRenderer.FillRectangle(new Rect(275, 60, 141, 96), brush);

            brush.Color = Color.FromArgb(0xFF, 0xA6, 0xC7, 0x46);
            sceneRenderer.FillRectangle(new Rect(-19, 163, 62, 45), brush);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x8F, 0x7C);
            sceneRenderer.FillRectangle(new Rect(643, 67, 161, 152), brush);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x8F, 0x7C);
            sceneRenderer.FillRectangle(new Rect(451, 81, 182, 146), brush);

            brush.Color = Color.FromArgb(0xFF, 0x4D, 0x67, 0x2F);
            sceneRenderer.FillRectangle(new Rect(573, 10, 29, 21), brush);

            brush.Color = Color.FromArgb(0xFF, 0x62, 0x5D, 0x58);
            sceneRenderer.FillRectangle(new Rect(646, 289, 238, 44), brush);

            brush.Color = Color.FromArgb(0xFF, 0x62, 0x5D, 0x58);
            sceneRenderer.FillRectangle(new Rect(875, 302, 181, 54), brush);

            brush.Color = Color.FromArgb(0xFF, 0x62, 0x5D, 0x58);
            sceneRenderer.FillRectangle(new Rect(1045, 317, 132, 55), brush);

            brush.Color = Color.FromArgb(0xFF, 0x62, 0x5D, 0x58);
            sceneRenderer.FillRectangle(new Rect(834, 141, 105, 103), brush);

            brush.Color = Color.FromArgb(0xFF, 0xB0, 0xAD, 0xAA);
            sceneRenderer.FillRectangle(new Rect(14, 462, 104.667, 44.667), brush);

            brush.Color = Color.FromArgb(0xFF, 0xB0, 0xAD, 0xAA);
            sceneRenderer.FillRectangle(new Rect(126.667, 480.667, 96, 120), brush);

            brush.Color = Color.FromArgb(0xFF, 0xB0, 0xAD, 0xAA);
            sceneRenderer.FillRectangle(new Rect(228.667, 518, 34.667, 31.334), brush);

            brush.Color = Color.FromArgb(0xFF, 0xB0, 0xAD, 0xAA);
            sceneRenderer.FillRectangle(new Rect(-14, 379.333, 90, 70), brush);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x77, 0x70);
            sceneRenderer.FillRectangle(new Rect(200, 344.667, 40.667, 103.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.FillRectangle(new Rect(36, 214, 26, 43), brush);

            brush.Color = Color.FromArgb(0xFF, 0x79, 0x82, 0x66);
            sceneRenderer.FillRectangle(new Rect(117, 138, 61, 90), brush);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x53, 0x42);
            sceneRenderer.FillRectangle(new Rect(34, 162, 53, 19), brush);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x53, 0x42);
            sceneRenderer.FillRectangle(new Rect(23, 135, 35, 53), brush);

            brush.Color = Color.FromArgb(0xFF, 0x51, 0x51, 0x4F);
            sceneRenderer.DrawLine(new Point(1130, 217.75), new Point(1140.75, 266.25), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x9D, 0x97, 0x7E);
            sceneRenderer.FillRectangle(new Rect(966.668, 61.337, 102.667, 161.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(51, 10.333), new Point(58.667, 17.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(55.333, 13), new Point(72, 12), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(68.667, 9.667), new Point(77.667, 17), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(77.667, 15), new Point(83.667, 21.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(85, 18.333), new Point(76.667, 35.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(77, 34.667), new Point(85.333, 40), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(91.333, 34), new Point(81, 44.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(81, 44.667), new Point(74, 54.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(124.333, 3), new Point(136.667, 9.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(135.333, 8.667), new Point(142.333, 28.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(141.667, 10.333), new Point(144.667, 26.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(138, 31.667), new Point(138, 43.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(132, 40), new Point(142, 43.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(144, 40.333), new Point(145.333, 57.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(151.667, 41.667), new Point(148, 51), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(141.667, 47.667), new Point(138.333, 56.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(116, 58.333), new Point(146, 78), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(124.667, 61), new Point(134.667, 63.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(130.667, 56.667), new Point(143.333, 75.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(142.333, 62.333), new Point(152, 74.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(134.667, 82.667), new Point(143, 84.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(141.333, 83.667), new Point(159.333, 77.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(73.667, 23), new Point(55.667, 23), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xAC, 0xA2);
            sceneRenderer.DrawLine(new Point(61.333, 24.667), new Point(76, 27.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x87, 0x6B, 0x50);
            sceneRenderer.DrawLine(new Point(1123.75, 200.25), new Point(1160.5, 201), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(169.333, 188.667), new Point(156, 197.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(156, 197.667), new Point(156, 204), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(155, 204), new Point(141.667, 201), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(153.333, 203.667), new Point(153.333, 215.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(154, 215.667), new Point(171.667, 213), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(167, 213.667), new Point(166.333, 224.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(169.333, 219.333), new Point(183, 231), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(189.667, 208.667), new Point(176, 221.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(173.667, 185.333), new Point(179.333, 216), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(167, 189.333), new Point(173.333, 219.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(160.667, 195.667), new Point(164.333, 211), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x83, 0x3A);
            sceneRenderer.DrawLine(new Point(156.667, 201.667), new Point(159.333, 211.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(71, 235.667), new Point(57.333, 236.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(57.667, 236.333), new Point(61.333, 243.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(60.667, 242.333), new Point(57, 246), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(57.333, 248.333), new Point(70.333, 251.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(67.667, 252), new Point(88.333, 253.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(85, 254), new Point(93.333, 256.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(89.667, 257.333), new Point(108.667, 250), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(105.333, 251.667), new Point(116.333, 251.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(110.333, 249), new Point(115, 242), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(120, 248.667), new Point(122.333, 221.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(123.667, 238), new Point(134, 233.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(130, 235), new Point(133, 219.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(128, 216.333), new Point(126, 231.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(116.333, 240), new Point(86, 253.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(119, 235.333), new Point(77.667, 248), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(82.333, 247), new Point(59, 243.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(115.333, 230.333), new Point(71, 243.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(103.333, 227.667), new Point(63.333, 240), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7F, 0x8C, 0x67);
            sceneRenderer.DrawLine(new Point(91.333, 226), new Point(69, 232), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x30, 0x2B);
            sceneRenderer.FillRectangle(new Rect(949.335, 216.669, 175, 87), brush);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x30, 0x2B);
            sceneRenderer.FillRectangle(new Rect(935.668, 22.339, 44, 84.667), brush);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(918.667, 83.332), new Point(943, 232.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(933.333, 96.332), new Point(953.333, 212.666), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(947.333, 230.666), new Point(945, 283.999), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(928.667, 235.666), new Point(931.667, 243.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(932.333, 246.332), new Point(937.667, 249.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(931.333, 242.332), new Point(939.667, 246.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(939.333, 231.999), new Point(939.333, 243.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(942, 233.666), new Point(940.333, 267.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(934.333, 248.666), new Point(939.667, 268.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(937.667, 248.332), new Point(929, 254.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(943.667, 231.332), new Point(942, 252.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(930.667, 273.332), new Point(947.667, 285.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(937, 266.332), new Point(939, 278.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(942.333, 267.999), new Point(941.333, 277.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(911.333, 288.332), new Point(921, 287.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(922, 287.332), new Point(935.333, 287.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(918.667, 284.666), new Point(924.333, 289.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(916.667, 289.999), new Point(921, 298.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(918.333, 297.999), new Point(929.333, 295.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(919.667, 291.666), new Point(928.333, 291.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(926, 291.666), new Point(940.667, 291.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(934, 292.999), new Point(942.333, 299.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(940, 297.999), new Point(970.667, 297.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(969.667, 297.999), new Point(985, 302.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(979, 296.666), new Point(974, 295.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(970.333, 295.999), new Point(962.333, 292.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(961.333, 291.999), new Point(953.333, 296.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(957, 295.999), new Point(939.667, 289.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(939.667, 291.332), new Point(946, 295.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(935.667, 277.332), new Point(938, 288.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(939.333, 284.332), new Point(946.667, 290.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(956.667, 271.332), new Point(944, 289.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(954.333, 281.666), new Point(957, 256.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(950, 274.332), new Point(955.667, 230.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(957.667, 235.999), new Point(958.667, 247.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(959, 243.332), new Point(968.333, 263.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(968, 265.666), new Point(967.333, 255.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(963.333, 242.332), new Point(963.333, 245.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(952.667, 236.999), new Point(948.667, 209.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(951.333, 209.999), new Point(959.333, 236.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(952.667, 210.666), new Point(963.667, 216.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(961.333, 214.332), new Point(962, 199.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(962.667, 200.666), new Point(955.667, 182.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(962, 187.332), new Point(964, 193.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(965.333, 187.332), new Point(965.333, 197.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(955, 180.666), new Point(964.333, 175.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(965.333, 175.666), new Point(966.333, 182.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(967.667, 170.999), new Point(967, 181.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(952.667, 161.666), new Point(960.667, 176.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(944.667, 288.332), new Point(955, 288.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(961.667, 285.332), new Point(951.667, 290.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(951, 283.999), new Point(959, 284.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(970.667, 286.332), new Point(964.333, 287.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(961.667, 285.999), new Point(967.667, 274.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(965.333, 267.666), new Point(962.333, 280.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(967, 270.332), new Point(968.667, 278.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(972, 276.666), new Point(967.333, 281.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(975.333, 222.999), new Point(980.333, 244.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(981.667, 227.999), new Point(981.667, 245.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(981.333, 242.666), new Point(986, 248.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(985, 248.999), new Point(1000.667, 248.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(998.667, 249.999), new Point(997.333, 256.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(987, 258.666), new Point(995.333, 260.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(994.667, 260.666), new Point(1010.333, 254.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1000.667, 256.332), new Point(1009, 259.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(995, 228.332), new Point(992.667, 242.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(984.333, 234.332), new Point(993.333, 241.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(980.667, 237.999), new Point(990.667, 247.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(989.333, 244.999), new Point(1018.333, 242.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1009.667, 236.332), new Point(993.333, 242.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1004, 233.666), new Point(999.667, 237.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1006.333, 236.999), new Point(1012.667, 240.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1004.667, 228.666), new Point(1039.333, 247.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1021, 236.999), new Point(1030.667, 238.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1016.333, 238.332), new Point(1014.667, 238.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1011, 236.666), new Point(1037.667, 250.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1032, 239.666), new Point(1037.667, 240.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1022.667, 246.666), new Point(1017, 260.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1017.667, 250.666), new Point(1007.333, 260.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1022.667, 246.999), new Point(998, 248.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(999.333, 253.999), new Point(1018.667, 253.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1031.333, 247.332), new Point(1031, 270.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1034.333, 252.332), new Point(1036.333, 271.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1029.333, 267.666), new Point(1029.667, 282.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1035.333, 274.666), new Point(1012, 298.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1027.667, 279.666), new Point(1007.667, 295.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1016.667, 276.332), new Point(1016.667, 287.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1016, 273.666), new Point(1020.667, 273.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1021.333, 265.666), new Point(1018, 265.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1021.333, 260.999), new Point(1018, 260.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1020.667, 268.332), new Point(1017, 271.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1010.667, 292.999), new Point(995.333, 292.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(996, 286.999), new Point(983, 293.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(977.667, 289.332), new Point(990.333, 290.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(982, 292.666), new Point(989.333, 297.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(996.667, 284.999), new Point(1002.333, 290.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1003.667, 288.332), new Point(1006.333, 288.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1000.667, 281.666), new Point(997, 281.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1003.667, 301.332), new Point(1003.667, 297.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1008.667, 295.332), new Point(1009, 301.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1017.667, 293.666), new Point(1021.333, 298.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(997, 296.666), new Point(999.333, 299.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(990.333, 300.666), new Point(995, 303.666), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(1000, 300.332), new Point(997, 298.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x5D, 0x4E);
            sceneRenderer.DrawLine(new Point(0, 176.332), new Point(928.667, 198.666), brush, 927.333f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.FillRectangle(new Rect(826.667, 37.667, 93, 96.667), brush);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(213, 183.333), new Point(215.333, 200.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(215.333, 199.667), new Point(222.333, 200), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(222.667, 199.333), new Point(225.333, 230.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(225, 230.667), new Point(198.333, 232.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(200, 232.667), new Point(192.333, 229), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(194.667, 228.667), new Point(184.333, 228.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(182.667, 228.667), new Point(179.333, 227.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(180.667, 228.333), new Point(197.333, 205.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(197.333, 200.333), new Point(183.667, 207.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(185.333, 207), new Point(177.333, 207), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(184, 199), new Point(215.333, 194), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(184.667, 193), new Point(211.667, 186), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(195, 201.333), new Point(221.333, 202.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(221, 204), new Point(194.667, 206.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(194, 213), new Point(223.667, 211.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(222.333, 217), new Point(188.333, 220), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x47, 0x32);
            sceneRenderer.DrawLine(new Point(187, 224.333), new Point(226.667, 225.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(5, 140.667), new Point(20.667, 150.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(14.667, 147.667), new Point(20.667, 161), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(19.667, 161), new Point(24.333, 171.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(24.333, 172), new Point(15, 174.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(15, 174.333), new Point(13.333, 180.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(13, 179.667), new Point(22.333, 191.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(22.667, 191.333), new Point(32.667, 188.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(29.333, 188.667), new Point(34, 193.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(34.333, 193.667), new Point(43, 199.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(41, 199.667), new Point(48, 220), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(48, 220.333), new Point(67, 221.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(66.333, 221.667), new Point(81, 217), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(69.667, 217), new Point(62.333, 213.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(64.333, 215.333), new Point(71.667, 210), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(71, 210.333), new Point(64, 195.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(64, 196.667), new Point(78, 183.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(76.667, 184.333), new Point(87.333, 187), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(87, 185.667), new Point(91.333, 177.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(91, 177.667), new Point(87, 174.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(87.667, 174.333), new Point(92.667, 170.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(92.667, 169), new Point(84, 169), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(83.333, 169), new Point(79.667, 157.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(78.333, 159), new Point(69, 159.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(69, 159.667), new Point(64, 147.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(64, 147.333), new Point(53.333, 144), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(53.333, 144), new Point(61.333, 125.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(61.333, 125.667), new Point(71.333, 128.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(70.667, 128.667), new Point(79.667, 126.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(80.667, 127.333), new Point(87, 135), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(87, 134.333), new Point(91, 126.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(91.667, 127.333), new Point(99.333, 129.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(99.667, 129.333), new Point(99.667, 123.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(99.667, 123.333), new Point(85.667, 121.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(89.333, 121.667), new Point(85, 115.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(84.667, 115.333), new Point(85.333, 111), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(85.333, 108.667), new Point(78.333, 111), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(80, 112), new Point(80, 114.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(80, 114.667), new Point(60.667, 104.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(61.333, 104.667), new Point(63, 93.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(63, 96.333), new Point(75, 93), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(72.667, 93.333), new Point(79.333, 96.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(79.333, 97), new Point(79.667, 86.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(80, 85.667), new Point(68.667, 85.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(68.333, 85.667), new Point(67.333, 79.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(67.333, 79.333), new Point(53.667, 87.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(53.667, 87.667), new Point(51, 91.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(50.333, 91.333), new Point(40, 87), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(42, 86.333), new Point(34.333, 95.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(33.667, 95), new Point(36, 102.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(36.333, 103), new Point(25.667, 111), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(31.333, 106.667), new Point(14.333, 102.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(14.667, 102), new Point(10, 92.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(10, 95.667), new Point(16.667, 94.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(21.333, 85.667), new Point(12.333, 90.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(18.667, 86.333), new Point(9, 86.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(1.667, 83.333), new Point(11, 95.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(0, 92.667), new Point(10.667, 99.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(0, 105.667), new Point(11.333, 112.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(8.667, 112), new Point(17.333, 107.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(14, 109.667), new Point(19, 118), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(26, 120.667), new Point(9.667, 121.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(10.667, 121.333), new Point(-3.333, 110), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(1.333, 116), new Point(0, 129.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(2.333, 130), new Point(10.667, 137), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(77, 88.333), new Point(57, 87.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(96.333, 126.667), new Point(17.333, 109.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(84.667, 117.667), new Point(35, 104.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(37, 97.333), new Point(60.667, 102.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(68.667, 93.667), new Point(35.667, 91), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(18, 117.667), new Point(61, 128.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(1.667, 125.667), new Point(56, 139.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(4.333, 120), new Point(58.333, 134), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(0, 99.333), new Point(17.333, 107.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(9.333, 137.667), new Point(57.667, 147.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(16.333, 145.667), new Point(85.333, 165.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(55, 148), new Point(68, 156), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(18.333, 156), new Point(88.667, 177), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(23.333, 167.667), new Point(83.667, 185.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(72.333, 186.667), new Point(15, 176), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(17.333, 183.667), new Point(67.333, 193), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(40.667, 188.333), new Point(57, 220), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x51, 0x41);
            sceneRenderer.DrawLine(new Point(53, 190.333), new Point(67, 220.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(61.333, 229.666), new Point(72, 232.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(58.667, 224.666), new Point(73.333, 228.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(71, 225.333), new Point(83.333, 219), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(79.333, 220), new Point(96.333, 226.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(94.333, 225.333), new Point(100.667, 216.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(100.333, 220), new Point(105, 227.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(101.667, 228), new Point(115.333, 222), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(113.667, 230), new Point(125, 226.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(124, 229), new Point(126.333, 215.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(126.667, 213.666), new Point(113.667, 212), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(119, 201.666), new Point(114.667, 210.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(127, 200.333), new Point(121, 201.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(121.333, 199.666), new Point(102.667, 204.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(107, 202.333), new Point(106.333, 192.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(105.333, 194.666), new Point(123.667, 185), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(124, 191), new Point(105.333, 188.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(119.667, 185.666), new Point(116, 166), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(100.667, 164.333), new Point(103.667, 183.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(103, 181.333), new Point(93.333, 180.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(93.333, 180.666), new Point(78.333, 192.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(105, 166.333), new Point(115.667, 158), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(114.667, 159), new Point(129.667, 150.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(127, 151.333), new Point(124, 141.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(125, 140.666), new Point(142, 149.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(138, 147.333), new Point(143.667, 157.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(140, 158.333), new Point(126.667, 154), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(128, 154.333), new Point(128, 164.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(127.667, 165.333), new Point(111.333, 162), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(114.667, 162.333), new Point(139.333, 146.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(138.333, 146.666), new Point(160.333, 125.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(141.667, 118.333), new Point(163, 124), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(135, 112.333), new Point(142, 114.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(137.667, 113.666), new Point(152.333, 113.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(150, 113), new Point(173.667, 129), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(166.333, 123.333), new Point(170.333, 107.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(169.333, 107.666), new Point(182.667, 107.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(180.667, 107), new Point(196.333, 118), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(175.667, 108), new Point(173.667, 131), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(150, 138), new Point(165, 142.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(160.333, 141), new Point(167.667, 153.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(167.667, 150.333), new Point(175, 158.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(172, 156), new Point(165.667, 165.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(166.667, 166), new Point(159.667, 174.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(159.333, 172), new Point(153, 178.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(153.333, 179), new Point(150.667, 187.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(147.333, 181.666), new Point(167.333, 173.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(167, 174.333), new Point(167.667, 187), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(167.667, 187), new Point(183, 187), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(182, 186.666), new Point(183, 196.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(176.667, 189), new Point(181.667, 196.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(185, 200), new Point(179.667, 199.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(181.333, 182), new Point(194.667, 193.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(194.667, 191), new Point(206.667, 189.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(208.333, 187), new Point(206.333, 196), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(200, 185.333), new Point(213.667, 180.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(209.667, 167.666), new Point(211.667, 186), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(205.333, 166.333), new Point(194, 173.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(197.667, 154), new Point(195.333, 167), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(191.333, 156.666), new Point(196, 169.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(195.333, 169), new Point(182.667, 169.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(186.333, 170), new Point(175.667, 177.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(165, 163.333), new Point(176.333, 186), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(202.667, 183), new Point(184, 185.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(210, 176.666), new Point(173.667, 182.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(209.667, 172), new Point(181, 176.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(169.333, 165.666), new Point(183, 157), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(180.667, 162), new Point(192.667, 118.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(183, 152.666), new Point(211.667, 120.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(186.667, 110.666), new Point(174.667, 155), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(181.333, 110.666), new Point(170.333, 148.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(169.667, 124.666), new Point(163.667, 144.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(163.333, 123.333), new Point(157.667, 138.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(191, 135), new Point(218, 99.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(201.333, 102), new Point(212.667, 102), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(210.333, 105), new Point(194, 112.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(193.667, 105), new Point(200, 122.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(200.667, 99.333), new Point(202.667, 124.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(188, 139.333), new Point(229, 115.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(229, 102.666), new Point(218.667, 116.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(220.333, 105), new Point(206.333, 123.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(218, 120), new Point(214.333, 91), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(218.667, 85.333), new Point(218.333, 89.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(215.667, 88.333), new Point(220, 95), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(211, 128.666), new Point(229.333, 129.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(230.667, 130), new Point(215.667, 117), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(214.333, 132), new Point(220.333, 139.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(217, 139.666), new Point(222, 150.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(223.333, 152.666), new Point(221.667, 146.666), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(230.667, 103), new Point(244, 103), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(243.667, 100.333), new Point(253.667, 108.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(250, 107.333), new Point(256, 109.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(267, 98), new Point(262.667, 102.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(252.333, 105.333), new Point(263.667, 101.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(263, 98.333), new Point(252.667, 100.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(249.333, 100.667), new Point(256.667, 98.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(256, 97.667), new Point(254, 90.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(256.667, 81.333), new Point(264.333, 96), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(258.333, 87.333), new Point(272.333, 90.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(272.333, 89.667), new Point(283.333, 101), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(281.333, 95.667), new Point(291, 95), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(282.667, 90), new Point(289.667, 78.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(296.667, 54), new Point(299.333, 68), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(299.333, 66.333), new Point(285, 83.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(273.333, 72), new Point(273.333, 88), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(283, 90), new Point(273.333, 87.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(240.667, 81), new Point(249.333, 76.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(244.667, 78.333), new Point(251, 41.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(251, 37.333), new Point(252.333, 73.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(257, 77), new Point(272.667, 76.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(255.667, 39), new Point(266.333, 39.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(266.333, 32.333), new Point(264.333, 38.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(266.667, 35), new Point(280.333, 81), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(281, 38), new Point(277, 51), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(282.333, 39.667), new Point(290.667, 75.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(277.333, 47), new Point(285.667, 78), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(287.667, 42.333), new Point(295, 68.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(255.333, 38), new Point(259.667, 73.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(261.667, 41.667), new Point(266.667, 76.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(280.333, 85.667), new Point(265.667, 50), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(247.667, 61.333), new Point(213, 69.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(227, 79.333), new Point(201.667, 71.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(221.667, 75.333), new Point(221, 59.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(233.667, 68.333), new Point(238, 53), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(236, 54.667), new Point(253.333, 61.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(242.333, 50.333), new Point(262, 62.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(157.667, 27.333), new Point(189.333, 70), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(162.667, 36), new Point(166, 56), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(164, 52.333), new Point(185.333, 71.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(170.667, 45.667), new Point(180.333, 78), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(163, 59.333), new Point(176.333, 74.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(164, 71), new Point(179.333, 79), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(180.667, 82.667), new Point(184, 80), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(178.333, 89.333), new Point(184, 83.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(171.333, 32.333), new Point(195.333, 69.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(184.667, 48), new Point(194, 31.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(187.667, 42.667), new Point(204.333, 70.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(189.667, 34.333), new Point(212.667, 72.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(194, 28.333), new Point(217.667, 67.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(207.667, 32.333), new Point(199.667, 38), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(206.667, 29), new Point(198, 29), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(216.333, 24.333), new Point(214, 31), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(210, 22), new Point(209, 32.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(217.333, 30), new Point(215.667, 33.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(221.667, 26.333), new Point(221.333, 26.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(204.667, 45.667), new Point(224, 47.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(209.333, 47), new Point(224.333, 65), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(174.667, 38.667), new Point(192, 46.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(136.667, 1), new Point(154, 14.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(150.333, 10.667), new Point(147.333, 15.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(147.333, 16), new Point(155, 21), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(153, 21), new Point(142, 28.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(140.333, 28.667), new Point(150.667, 43.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(151.667, 43.667), new Point(158.667, 43.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(157.333, 43.334), new Point(156.667, 53.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(156.333, 52.334), new Point(144, 51), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(148.333, 51.667), new Point(152.333, 61.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(151.333, 61.334), new Point(140.667, 58), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(150, 62.334), new Point(160.667, 70.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(155.333, 68), new Point(143.333, 72.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(149.333, 71.667), new Point(158.667, 92.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(157.333, 90.334), new Point(145, 94.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(146, 94.667), new Point(144.333, 103.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(134, 96), new Point(143, 99.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(134, 96), new Point(132.333, 88), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(132.333, 89), new Point(123.333, 89.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(124.667, 89.334), new Point(113.667, 90), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(116, 90), new Point(104, 89), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(105.667, 89.334), new Point(102.667, 93.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(111, 90.334), new Point(123, 99.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(119.667, 98.334), new Point(118, 103.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(116.667, 104), new Point(111, 108.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(105.667, 100.334), new Point(103, 105.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(98.667, 101), new Point(98, 107), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(106.667, 103), new Point(117, 107), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(119, 105.667), new Point(127, 111.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(118, 99), new Point(118, 108), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(120.333, 100.667), new Point(146, 111), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(121, 93), new Point(151, 105.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(133.667, 114.334), new Point(133.667, 134.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(136.667, 128.667), new Point(116, 130.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(117, 130), new Point(105, 121.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(105.667, 121.334), new Point(112, 113.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(113, 111.334), new Point(101, 106.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(101.667, 106.667), new Point(102.333, 116), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(102.333, 114.334), new Point(90.667, 115.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(92, 115.334), new Point(106.667, 119.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(101.667, 110.334), new Point(114.333, 115.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(99.333, 119.334), new Point(106.333, 134.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(83.333, 133.334), new Point(78.667, 138.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(79, 138.334), new Point(95.333, 143), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(92.667, 143.334), new Point(101.667, 145.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(99.333, 147.334), new Point(91.667, 154.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(92.667, 156.334), new Point(96.667, 161.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(96, 162), new Point(88, 164), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(93, 164.667), new Point(103, 163.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(95.333, 163.667), new Point(132, 130.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(102.667, 162.667), new Point(154, 125.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(96.667, 153.667), new Point(118.667, 131.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(129.667, 139.667), new Point(147.667, 118.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(118.333, 137.667), new Point(144.667, 114.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(143, 127.334), new Point(196.333, 66), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(84.667, 135), new Point(108, 142), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(89, 131.334), new Point(114, 138.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(94, 129), new Point(124, 132.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(156.333, 48), new Point(159, 98.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(162, 48), new Point(163.333, 99), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(147.667, 100), new Point(160, 95), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(169, 74.667), new Point(170.333, 92.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(188, 69.334), new Point(146.667, 111.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(201.667, 70), new Point(159, 119.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(205.333, 74), new Point(179.667, 106), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(210.333, 76), new Point(185.667, 107.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(216.333, 78), new Point(192, 109), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(222.667, 79.334), new Point(205, 100.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(229.333, 66), new Point(218.333, 110.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(237.333, 62), new Point(226, 105.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(243.667, 62.334), new Point(234.667, 102.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(253.667, 71.334), new Point(239.333, 101.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(258.667, 73), new Point(245.667, 101), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(273.333, 78.334), new Point(248.333, 92.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(263.333, 34.667), new Point(262, 25.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(262.333, 24.667), new Point(269.333, 25.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(271, 26), new Point(274.667, 28.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(277.333, 29.334), new Point(268.667, 20), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(265.333, 19.667), new Point(271.667, 25.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(269.333, 23.334), new Point(257, 14.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(261, 4.667), new Point(261.333, 12.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(266.333, 1.667), new Point(266.333, 9.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(259, 15.333), new Point(245.667, 0), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(247.333, 3), new Point(139.667, 2.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(147.333, 10), new Point(255, 11), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(255.333, 16.333), new Point(153, 17), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(151.667, 25), new Point(265.667, 21.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(144.667, 31), new Point(263.667, 28.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(264, 33), new Point(149, 37.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(151.667, 42.667), new Point(255, 40), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(252.667, 46.667), new Point(219.333, 46.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(217.667, 53.333), new Point(244.667, 52.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x81, 0x66);
            sceneRenderer.DrawLine(new Point(236.667, 57.333), new Point(217.333, 60.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(2, 0), new Point(2.333, 24.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(3.333, 23.333), new Point(7.333, 27.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(8.333, 27.667), new Point(14.667, 21), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(14.667, 20.667), new Point(28, 35.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(4.667, 3), new Point(53.333, 3.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(52.333, 2.333), new Point(48, 10.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(47.333, 10.667), new Point(57.667, 27), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(58, 23), new Point(63.667, 19), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(60, 20), new Point(65.667, 13.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(63, 13), new Point(76.333, 20), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(74.667, 20.667), new Point(77, 30), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(75.667, 29), new Point(67.667, 34.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(70, 32), new Point(49, 27), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(51.333, 28.333), new Point(54.333, 43.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(58, 31.667), new Point(57.667, 46.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(56.667, 40), new Point(71.667, 44.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(72.333, 35), new Point(71.667, 49.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(78.667, 36), new Point(72, 53.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(73, 53.667), new Point(79.333, 59.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(94, 57), new Point(75.667, 62), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(79, 61.667), new Point(77.667, 69.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(77.333, 67.333), new Point(67, 63), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(66, 62.667), new Point(68.667, 66.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(56, 64.667), new Point(63.333, 83), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(63.333, 76.333), new Point(80.667, 83), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(60, 67.667), new Point(73, 56.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(2.667, 33), new Point(1.333, 70.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(7.333, 36.333), new Point(7.333, 69.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(14.333, 32.333), new Point(13.667, 78.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(16.333, 59.667), new Point(20.333, 76.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(19, 73.333), new Point(27.667, 91.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(19, 90.333), new Point(32.333, 90.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(26.667, 73.333), new Point(36.667, 96.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(31.667, 71.333), new Point(45.333, 90.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(35.667, 76.333), new Point(56, 87.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(33, 71.667), new Point(46.667, 74.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(42.667, 82), new Point(61.667, 84), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(24.333, 45.667), new Point(40.667, 55), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(38.667, 54.333), new Point(64.667, 46), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(44.667, 52), new Point(66, 60.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(54.667, 54.333), new Point(72.667, 53), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(63, 45.333), new Point(79.333, 65), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(59.667, 59.333), new Point(52, 68), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(29.333, 65.667), new Point(29.333, 49), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(27.667, 62), new Point(18.333, 58), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(21.667, 59.333), new Point(22.333, 31.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(22, 37.667), new Point(50.667, 51.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(56, 46.667), new Point(24.333, 29.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(6.667, 6.667), new Point(8.667, 23.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(12.333, 5.667), new Point(17, 23), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(12.333, 12), new Point(50, 41.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(16, 6.667), new Point(52.667, 34), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(24.333, 6), new Point(50, 25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(34, 4.667), new Point(49, 18), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(40.333, 4.333), new Point(49, 12.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(76, 81.333), new Point(86, 87.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(83, 87.333), new Point(87.667, 96.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(82, 94.667), new Point(78.667, 106), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(76.667, 96), new Point(62, 104.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(64.667, 101.667), new Point(82, 109.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(93, 109), new Point(69.333, 100.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(92, 94), new Point(100.667, 100), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(89.667, 94), new Point(98, 92.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(2.667, 126.333), new Point(3, 176), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(6.667, 135), new Point(7.667, 155.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(13.667, 145.667), new Point(3.333, 161), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(3.333, 163.667), new Point(15.333, 175.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(20.667, 159.667), new Point(10.667, 167.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x63, 0x58);
            sceneRenderer.DrawLine(new Point(21.667, 167), new Point(11.333, 170.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(0, 202.333), new Point(16, 202.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(14.667, 202.667), new Point(26, 211.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(24.333, 210.667), new Point(30, 205), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(29.333, 200), new Point(33.667, 209.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(32.667, 209.667), new Point(40.667, 217.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(46.667, 213.667), new Point(39.333, 218.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(46, 222.667), new Point(-5.333, 206.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(9, 206.333), new Point(33.667, 213.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(43.667, 227.667), new Point(-11.333, 212.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(0, 220.333), new Point(42.667, 235), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0xAE, 0x3F);
            sceneRenderer.DrawLine(new Point(38.333, 235.667), new Point(40, 242.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(-1.667, 225.333), new Point(9, 227.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(7, 228), new Point(15.333, 220.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(15.667, 220.333), new Point(14.667, 215.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(9, 205.333), new Point(9.333, 211.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(10, 210), new Point(13.333, 215), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(13.667, 213), new Point(17.667, 217), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(18.667, 216.667), new Point(17.667, 227.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(15.667, 228), new Point(29, 234), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(25.333, 228.333), new Point(30.667, 228), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(31.333, 228), new Point(29, 234), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(26, 237), new Point(35.333, 238.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(38, 239.667), new Point(44.667, 235.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(40, 225.333), new Point(40.333, 235), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(39, 237.333), new Point(34, 239.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(46.667, 227), new Point(46, 235.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(50.667, 221.667), new Point(44.667, 232.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(48.333, 233.667), new Point(39.333, 242.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(39.333, 242.667), new Point(38.333, 251), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(40, 250.667), new Point(-10, 254.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(37, 243.667), new Point(-7.667, 248.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(28.333, 237.667), new Point(-10.667, 241.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(24.333, 233.667), new Point(0, 232.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6E, 0x8A, 0x3A);
            sceneRenderer.DrawLine(new Point(19.333, 226.667), new Point(-2, 230.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x48, 0x4F, 0x2F);
            sceneRenderer.FillRectangle(new Rect(611.333, 34.667, 138.667, 65.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(108.667, 165), new Point(111.667, 186.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(108, 183.333), new Point(71.333, 216.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(99, 183.333), new Point(69, 207.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(79.667, 189.333), new Point(69.333, 200), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(105, 193.667), new Point(79.333, 219.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(104.667, 203.333), new Point(86.667, 221.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(114.333, 204.333), new Point(99, 218.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(115.667, 211), new Point(104.333, 223), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(120.667, 213.667), new Point(113.333, 223.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x5C, 0x67, 0x49);
            sceneRenderer.DrawLine(new Point(124.667, 217.333), new Point(115.333, 225), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(109.333, 52), new Point(105, 66.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(104.333, 67), new Point(104, 75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(103.667, 75), new Point(97.667, 66.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(95.333, 64.667), new Point(93.667, 78), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(94, 77.333), new Point(85, 93.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(107.333, 56.667), new Point(101, 50.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(100.667, 50), new Point(84.333, 55), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(100.667, 46.333), new Point(89.667, 68), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(103.333, 55), new Point(95.333, 67.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(87, 62), new Point(79, 74.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(89.667, 64), new Point(86, 77), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x81, 0x8D, 0x74);
            sceneRenderer.DrawLine(new Point(88, 81.667), new Point(62.667, 68), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(138.667, 159), new Point(141.333, 179.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(141, 179.333), new Point(137.333, 185.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(137.333, 185.333), new Point(145.333, 192.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(145.333, 192.667), new Point(154.333, 193.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(152.333, 194), new Point(166.667, 186), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(132.333, 161.333), new Point(130.667, 177.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(130, 177), new Point(118.667, 174), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(133.667, 158), new Point(136, 185), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(130, 176.667), new Point(128, 200.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(122.667, 177), new Point(122.667, 196.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(122.667, 195.333), new Point(105.333, 200.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(137, 184.333), new Point(131.667, 195.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(132, 195.667), new Point(142, 193), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(138.667, 193.333), new Point(142.667, 203.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(141, 204), new Point(138.333, 209), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(124.333, 202.333), new Point(123.667, 213.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(128, 198), new Point(132.667, 205.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(139, 208.667), new Point(142.667, 221.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(145.333, 206.333), new Point(152.333, 228.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(139.667, 224.333), new Point(156, 229.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(154, 227), new Point(165, 227), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(163.333, 227), new Point(188, 230.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x95, 0x9F, 0x64);
            sceneRenderer.DrawLine(new Point(148.667, 218.333), new Point(168, 222.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(172.333, 171.333), new Point(188.666, 160.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(187.333, 166.333), new Point(192.333, 146), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(214.666, 129), new Point(193, 150.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(217.333, 138), new Point(191.333, 157), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(218.333, 143.333), new Point(195.333, 161), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(203.666, 154.667), new Point(211, 168), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(199.666, 157.667), new Point(205.666, 171.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(215, 147.333), new Point(224.333, 158), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(225.333, 156.333), new Point(221.333, 169), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(223, 162.333), new Point(231.666, 177), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(244.333, 137.667), new Point(244.333, 160.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(244.333, 157.333), new Point(236.666, 175.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(237.666, 176), new Point(237.666, 182), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(237.666, 183), new Point(241, 181.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(239.666, 175.667), new Point(253, 182), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(248.666, 185.333), new Point(254.666, 188.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(251.333, 181.333), new Point(271.666, 192.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(270.333, 192.333), new Point(277, 195.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(280, 200.667), new Point(274.666, 198.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(265, 166.333), new Point(275.333, 191), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(269.333, 139.667), new Point(266.333, 168), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(261.333, 104.667), new Point(269.333, 146), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(265, 127), new Point(226.333, 115), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(225.666, 109), new Point(262.666, 119), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(262, 112.667), new Point(229.333, 103.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(258.333, 132.667), new Point(215.333, 119), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(262.666, 135), new Point(258.333, 140), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(258, 145), new Point(260.666, 146), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(252, 143.333), new Point(243.666, 137), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(253.333, 135), new Point(224, 130.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(221, 131.667), new Point(242.333, 139.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(237.333, 140), new Point(239, 159.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(233, 137), new Point(236.666, 172.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(227, 134), new Point(232, 168.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(220.666, 133), new Point(225.666, 158.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(279.333, 99), new Point(284.666, 146), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(288, 109), new Point(288, 140.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(295, 123), new Point(291.333, 146), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(301.333, 131.667), new Point(294.666, 149.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(302, 127), new Point(306.333, 129), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(304.333, 128.667), new Point(304, 164.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(298.333, 146.333), new Point(294.666, 157), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(299.666, 152.333), new Point(297.333, 167.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(296.333, 161.333), new Point(291.666, 166), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(294.333, 163.333), new Point(288.666, 180), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(289, 178.667), new Point(276, 189.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(285.333, 180.667), new Point(272.666, 181), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(274.666, 147.667), new Point(266.333, 100.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(274.666, 93.333), new Point(277.666, 135.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(266.333, 90), new Point(270.666, 103.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(275.333, 143.333), new Point(270, 156), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(240.666, 173.667), new Point(250, 166), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(254.666, 162.667), new Point(253, 168.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(301, 61.667), new Point(313.333, 78.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(313.333, 78), new Point(313.333, 85.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(313, 82.333), new Point(308.333, 88), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(302.666, 82.333), new Point(297.333, 91.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(297.333, 92), new Point(302.666, 102.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(302.666, 103), new Point(307, 111.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(305.666, 112), new Point(299.333, 114.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(299, 113), new Point(303, 117.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(304.666, 114), new Point(313, 118.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(310.333, 115.667), new Point(316.333, 129), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(315.666, 129.333), new Point(318.666, 148.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(307.333, 140.333), new Point(319.666, 150.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(295, 168.667), new Point(312, 165.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(309, 144), new Point(311.666, 171.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(311.333, 171), new Point(311.333, 183.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(310.666, 179), new Point(323.333, 194.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(322.333, 194.333), new Point(322, 205.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(321.333, 200), new Point(322, 178.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(323.666, 179.333), new Point(332.666, 171), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(332.666, 172.667), new Point(336.333, 193.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(337.666, 192), new Point(347.666, 188.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(344.333, 192.333), new Point(345, 202.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(348.333, 204.333), new Point(347.666, 170.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(347.666, 175.667), new Point(358.333, 124), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(350.666, 135.333), new Point(343.333, 167), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(342.666, 149.667), new Point(335, 163.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(337.333, 159), new Point(340.666, 188), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(341, 184.667), new Point(345.333, 160.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(334, 172.667), new Point(312.666, 83), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(305.666, 83.333), new Point(320.666, 136), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(301, 86.333), new Point(311.333, 120.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(320.333, 133.333), new Point(327, 172), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(318.333, 148.333), new Point(322.666, 181.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(315, 148.667), new Point(316.666, 180.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(302, 41.333), new Point(336, 118.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(319.333, 84.333), new Point(330, 129.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(326.666, 127), new Point(328.666, 140.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(306, 66.667), new Point(296.666, 45), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(290, 39.333), new Point(294, 43.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(291.333, 48), new Point(295.666, 47.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(307.333, 51.667), new Point(317, 43), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(314, 45), new Point(364.333, 43.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(324, 27), new Point(334.333, 45.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(329.666, 23.333), new Point(344.666, 45.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(335, 23.333), new Point(341, 35), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(340, 38), new Point(322.333, 40.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(315, 12.667), new Point(318.333, 11.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(318.666, 11), new Point(335, 12), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(324.666, 12.667), new Point(332, 18), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(326, 11.333), new Point(329.333, -3), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(328.333, 9), new Point(340.666, 3.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(331.333, 11), new Point(342, 14.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(339.666, 10.667), new Point(350.333, 10.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(343.666, 21.667), new Point(346.666, 19.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(339.333, 15), new Point(349.666, 13.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(348, 9.667), new Point(358.666, 13.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(363.666, 8.667), new Point(349, 6), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(357.666, 11), new Point(362, 14.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(361.333, 9), new Point(365.666, 9.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(372, 4.667), new Point(370, 7.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(372.666, 8.667), new Point(364, 9), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(373, 13), new Point(376.666, 11.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(377, 15.667), new Point(373.333, 18.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(326.333, 49), new Point(320, 72), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(321.666, 46.667), new Point(315.333, 64), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(316.333, 47), new Point(313.666, 59.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(326.333, 56.333), new Point(332.333, 62.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(332, 61.667), new Point(356, 47.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(353, 47.667), new Point(323.666, 55.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(341.333, 47.333), new Point(318, 47.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(339.666, 67.667), new Point(355.333, 53.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(344.333, 68.667), new Point(353.666, 62.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(361.333, 56.333), new Point(359.666, 61.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(354.666, 69.667), new Point(358.333, 66), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(363.666, 66), new Point(360.666, 71.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(368.333, 70), new Point(363, 74), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(373, 70.667), new Point(370.333, 77.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(369.333, 79.667), new Point(374, 79.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(368.333, 79), new Point(358, 98), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(370.666, 79.667), new Point(369, 98.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(370, 98), new Point(351.333, 97.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(366.333, 93.667), new Point(345.333, 87.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(353.333, 80.333), new Point(342, 97.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(342, 96), new Point(341, 100), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(343, 99.333), new Point(356, 93.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(353.333, 80.333), new Point(359.666, 90.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(349.333, 98), new Point(349, 107.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(346.666, 108.333), new Point(355, 114.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(351.333, 110), new Point(357.333, 108.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(358.333, 109), new Point(376.666, 126.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(322, 71.333), new Point(334.666, 99), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(328.333, 75.333), new Point(337.333, 91.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(334, 73.333), new Point(335.666, 77.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(336.666, 68), new Point(337.333, 73.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(374.333, 70.333), new Point(384.666, 75.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(391.666, 69), new Point(379.333, 71.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(379, 63), new Point(379.666, 68.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(385.333, 60), new Point(385.333, 64.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(388.333, 58), new Point(390.666, 63), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(382.666, 66), new Point(385.333, 66), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(384.666, 72.667), new Point(381, 96.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(387.333, 75.667), new Point(389.333, 103.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(393.666, 79), new Point(394, 128.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(398, 76.667), new Point(399.666, 127.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(401, 84.667), new Point(401, 102.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(405, 97.667), new Point(406.666, 123.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(408, 93), new Point(408.333, 98), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(367.333, 107.333), new Point(388.666, 132.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(378, 129.333), new Point(389.333, 135.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(391.333, 134), new Point(388.666, 134), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(369, 109.333), new Point(380.333, 103.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(389.333, 101.333), new Point(380, 106.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(376, 105), new Point(387.666, 125.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(386.666, 105.667), new Point(390.666, 125.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(352.333, 115), new Point(372.333, 130.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(330.333, 125.667), new Point(343, 117.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(345, 118.333), new Point(346.333, 132), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(353.333, 119), new Point(350.333, 134.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(366.333, 125.667), new Point(360, 141.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(362.666, 137.333), new Point(367, 157.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(360, 138.667), new Point(358, 163.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(359.666, 154), new Point(365.666, 182.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(353, 159.667), new Point(363.666, 170), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(368.666, 154.333), new Point(363, 168), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(363, 176), new Point(366, 185.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(407.666, 107.667), new Point(415, 116.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(415.333, 112), new Point(427, 110), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(424, 113), new Point(419, 119.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(418.666, 113.667), new Point(414.333, 120.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(412.333, 114.667), new Point(412.666, 129), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(411.333, 124.667), new Point(400.333, 146.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(397.666, 146), new Point(405.666, 154.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(405, 158.333), new Point(402.666, 161.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(406.666, 160.333), new Point(426.666, 158.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(405.666, 159.333), new Point(427.666, 124), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(432, 115), new Point(428, 124.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(422.333, 119.667), new Point(405.333, 149.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(433.333, 130), new Point(414.333, 155.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(437, 135.667), new Point(419.666, 156.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(442.666, 139.667), new Point(426.666, 151.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(424.666, 153.667), new Point(435.333, 154.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(449.666, 145.333), new Point(434.333, 155.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(440.666, 155), new Point(441.666, 158), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(426, 154), new Point(429, 169), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(430.666, 167), new Point(442.666, 179.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(438.333, 176), new Point(455.333, 178.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(450.666, 162), new Point(455.333, 174), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(451, 170.333), new Point(464, 196.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(461.333, 195), new Point(449.333, 195), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(455.333, 195), new Point(432.666, 185.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(429.666, 180.667), new Point(435.333, 182.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x51, 0x35);
            sceneRenderer.DrawLine(new Point(441, 181.667), new Point(458, 188), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(493.333, 9.002), new Point(406, 71.335), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(552.666, -6.331), new Point(476, 44.335), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(435.333, 113.002), new Point(541, 42.335), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(783.332, 64.002), new Point(730.332, 76.669), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(619.332, 122.002), new Point(598.332, 29.335), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(556.999, 23.335), new Point(569.999, 84.335), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(633.332, 45.669), new Point(826.332, -9.331), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(717.665, 3.669), new Point(595.665, 13.669), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(565.999, 5), new Point(576.665, 20.669), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(639.998, 154.669), new Point(644.332, 134.335), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(644.332, 134.002), new Point(644.332, 104.669), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(644.665, 104.669), new Point(639.665, 77.002), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(648.332, 103.669), new Point(682.332, 98.002), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(682.665, 98.335), new Point(696.332, 96.669), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(622.998, 24.002), new Point(631.332, 57.002), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(496.999, 116.335), new Point(469.666, 133.669), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(555.666, 63.335), new Point(515.666, 99.335), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(592.332, 128.002), new Point(589.666, 102.669), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(592.666, 80.002), new Point(585.666, 97.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(498.666, 103.335), new Point(511.332, 108.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(506.999, 103.335), new Point(514.999, 94.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(547.999, 83.002), new Point(535.999, 99.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(543.332, 97.335), new Point(534.999, 103.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(583.666, 79.669), new Point(581.332, 93.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(472.666, 142.335), new Point(491.666, 133.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(471.332, 127.002), new Point(454.999, 137.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(629.666, 118.335), new Point(638.999, 134.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(655.332, 135.002), new Point(645.666, 134.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(605.666, 123.002), new Point(606.999, 140.002), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(603.999, 141.335), new Point(626.332, 159.002), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(599.332, 122.669), new Point(596.332, 148.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(600.999, 136.335), new Point(611.666, 155.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(611.332, 153.669), new Point(617.332, 159.002), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(628.999, 162.335), new Point(613.666, 155.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(737.999, 89.669), new Point(693.666, 100.002), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(736.332, 85.669), new Point(688.999, 96.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(785.332, 39.002), new Point(728.999, 56.002), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(781.666, 38.335), new Point(782.666, 75.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(714.332, 41.002), new Point(734.332, 56.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(723.332, 50.002), new Point(717.666, 64.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(711.332, 54.002), new Point(732.332, 64.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(709.332, 73.669), new Point(730.999, 65.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(718.666, 77.669), new Point(740.332, 71.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(731.999, 80.335), new Point(717.332, 85.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(685.666, 86.669), new Point(642.332, 98.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(650.332, 72.669), new Point(657.999, 90.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(673.666, 68.335), new Point(652.332, 79.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(685.666, 67.669), new Point(671.666, 67.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(646.999, 81.335), new Point(621.666, 77.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(628.666, 51.669), new Point(642.332, 60.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(555.332, 3.335), new Point(598.999, 5.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(602.999, 14.002), new Point(576.999, 9.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(577.666, 16.002), new Point(575.332, 36.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(576.666, 28.669), new Point(594.666, 35.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(600.999, 23.002), new Point(589.332, 31.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(592.999, 92.669), new Point(584.666, 109.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(639.666, 152.335), new Point(645.332, 165.669), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(646.999, 153.669), new Point(641.999, 184.002), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(638.666, 179.669), new Point(638.999, 193.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(786.332, 22.669), new Point(869.998, -1.331), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(826.998, 5.667), new Point(857.665, 1), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x17);
            sceneRenderer.DrawLine(new Point(849.665, 1.002), new Point(814.998, 1.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(368, 135.334), new Point(373, 158.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(373.333, 158.334), new Point(367.666, 174.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(367.666, 174.334), new Point(369, 192.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(369, 192.668), new Point(373.666, 201.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(376.333, 203.334), new Point(373.333, 193.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(374, 187.334), new Point(377.333, 193.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(370.666, 141.001), new Point(394.666, 151.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(391.666, 149.334), new Point(400, 149.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(402.333, 155.001), new Point(376, 154.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(376.333, 144.668), new Point(376, 186.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(381.333, 171.668), new Point(378.333, 183.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(385.666, 186.334), new Point(387.666, 182.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(385.666, 179.001), new Point(383.666, 185.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(385.666, 187.001), new Point(390.666, 191.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(395, 193.334), new Point(393.666, 189.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(396, 185.668), new Point(397, 192.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(379, 165.334), new Point(395, 157.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(391.666, 158.668), new Point(426.333, 185.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(429.333, 176.668), new Point(406.666, 161.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(414, 161.001), new Point(423.666, 165.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(396, 163.668), new Point(394, 176.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(401.666, 169.001), new Point(400.333, 173.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(406.333, 175.334), new Point(412.666, 180.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(408.333, 181.001), new Point(423, 194.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(424, 186.001), new Point(425, 199.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(417.666, 189.001), new Point(417.666, 200.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(408.666, 68.668), new Point(403, 86.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(416.333, 71.001), new Point(405.333, 96.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(424.333, 73.001), new Point(409, 105.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(432.666, 72.334), new Point(413, 112.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(442.333, 72.334), new Point(419, 109.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(447.333, 80.334), new Point(424.666, 105.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(449.333, 93.334), new Point(428.666, 110.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(432.666, 107.668), new Point(423.666, 121.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(432.333, 114.334), new Point(437, 118.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(451.333, 108.001), new Point(430.666, 127.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(449.333, 117.334), new Point(439, 133.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(438.333, 133.334), new Point(435, 135.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(440.666, 130.001), new Point(436, 141.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(455, 123.668), new Point(440.333, 146.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(460.666, 129.334), new Point(445, 150.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(475, 129.001), new Point(440.666, 162.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(461, 148.668), new Point(466, 160.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(467.666, 163.668), new Point(472.666, 160.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(474.333, 142.334), new Point(468, 153.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(472.666, 137.334), new Point(459.666, 147.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(456.666, 159.001), new Point(457, 170.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(458, 172.668), new Point(463.666, 186.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(471, 169.334), new Point(466, 177.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(494, 149.001), new Point(483.666, 155.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(478.333, 148.668), new Point(477, 151.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x37, 0x26);
            sceneRenderer.DrawLine(new Point(483.333, 154.668), new Point(480.333, 159.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(555.333, 10.668), new Point(538.667, 11.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(550, 11.335), new Point(538, -1.999), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(542, 5.001), new Point(528, 5.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(534.333, 6.335), new Point(525.333, 10.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(525.333, 10.335), new Point(516.333, 17.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(521.667, 16.335), new Point(509.667, 3.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(529, 4.001), new Point(511.333, 4.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(503.667, 1.668), new Point(503.333, 19.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(509, 16.335), new Point(506.333, 36.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(498.667, 33.001), new Point(502.667, 36.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(487, 42.335), new Point(493.667, 40.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(501, 18.335), new Point(488.667, 42.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(506.333, 20.001), new Point(495.333, 38.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(504, 36.001), new Point(497.667, 42.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(489.333, 18.001), new Point(491.333, -9.665), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(498, -2.332), new Point(494.333, 18.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(514, 1.335), new Point(480.667, 1.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(475.333, 11.335), new Point(478.667, -9.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(484.333, 1.668), new Point(473.667, 9.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(475.333, 0), new Point(439, 3.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(463.667, 3.335), new Point(465.333, 14.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(462, 18.668), new Point(455.333, 0), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(450.667, 4.668), new Point(446.333, 18.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(441, 21.335), new Point(445.667, 27.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(448.667, 30.335), new Point(445.333, 28.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(446.333, 18.668), new Point(414.667, 17.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(426.667, 3.335), new Point(400.667, 41.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(401, 7.335), new Point(405.333, 12.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(404.667, 9.335), new Point(448.333, 5.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(442.333, 1.335), new Point(402, 3.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(446.667, 11.668), new Point(417.667, 12.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(490.667, 15.668), new Point(500, 24.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(438, 22.334), new Point(407.333, 52.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(429.667, 19.001), new Point(401.667, 49.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(421.333, 21.001), new Point(389.333, 52.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(407.667, 50.001), new Point(401.333, 67.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(402.667, 47.334), new Point(394.333, 66.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(401.667, 65.334), new Point(393.667, 76.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(392.333, 73.001), new Point(390, 78.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(394.667, 61.001), new Point(389.667, 71.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(392.333, 61.668), new Point(383, 68.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(396.333, 53.668), new Point(374.667, 63.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(377, 60.334), new Point(365.667, 63.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(391.333, 51.668), new Point(354.667, 56.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(391, 49.001), new Point(352.667, 48.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(354.333, 40.001), new Point(366.667, 34.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(361, 34.334), new Point(393.333, 35.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(370.667, 26.334), new Point(375.667, 28.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(372, 21.334), new Point(376.667, 22.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(389.333, 15.668), new Point(381.333, 31.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(379.667, 12.334), new Point(386, 14.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(384.333, 9.334), new Point(388.667, 9.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(386.667, 16.668), new Point(401.333, 9.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(402.667, 13.001), new Point(388, 31.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(405.667, 19.668), new Point(388, 44.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x31, 0x38, 0x22);
            sceneRenderer.DrawLine(new Point(391.667, 41.334), new Point(363, 41.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(719.333, 44.667), new Point(794.333, 22.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(726.667, 47.667), new Point(756, 39.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(789.667, 31), new Point(862, 5.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(785, 27.333), new Point(832.667, 13.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(861, 8), new Point(880.333, 7.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(874.667, 7.667), new Point(886, 19.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(884, 19), new Point(899.333, 46), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(899.667, 46), new Point(910, 71.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(910, 71.667), new Point(917, 99.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(917, 99.667), new Point(917.667, 109), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(921, 99.667), new Point(921, 77.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(908.333, -3), new Point(909.333, 9.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(909.667, 9.333), new Point(918.667, 25.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(919, 25.667), new Point(927.667, 39), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(930.667, 39), new Point(926, -7.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(969, -1.333), new Point(967.333, 11), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(967.333, 11.333), new Point(974, 33.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(974.333, 33.667), new Point(956.667, 23.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(955, 24), new Point(951.667, 51.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(952, 51.667), new Point(940.667, 85), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(920.667, 84), new Point(928.667, 80), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(928.333, 80.667), new Point(930.333, 87.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(930.333, 87.333), new Point(929.333, 97.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(930.667, 97.333), new Point(939.667, 97.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(938.667, 97.667), new Point(943.333, 107.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(943, 107.667), new Point(943, 125.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(943, 126), new Point(950.667, 140.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(950.667, 140.333), new Point(952.333, 154.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(949.333, 153.333), new Point(955.333, 164), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(952, 169.667), new Point(956.667, 169.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(957, 174.333), new Point(954.333, 176), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(954, 165), new Point(954, 170.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(972.333, 40), new Point(965, 112), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(967, 111.667), new Point(968.333, 123.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(968.667, 38.667), new Point(963.667, 48), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(965.333, 44), new Point(961.333, 68.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(960.667, 67.333), new Point(959, 84.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(967.333, 44.667), new Point(959.333, 110.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(958.667, 81.667), new Point(957, 104), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(941, 83.667), new Point(944, 92.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(943.333, 93.667), new Point(951.667, 98.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(950.333, 98.333), new Point(956.667, 98.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(973.333, 120.667), new Point(970.667, 172.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(965.667, 174.667), new Point(962, 173.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(964.667, 171.333), new Point(968.667, 122.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(963, 111), new Point(962, 165), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(957, 106.333), new Point(957, 163.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(963, 111.333), new Point(934.333, 90.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(951, 102), new Point(954, 158), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(946, 100), new Point(947, 134.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(887.333, 2), new Point(934.667, 72), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(943, -1.667), new Point(943.333, 27), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(951.667, -4.667), new Point(956.333, 30), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(928.333, 41), new Point(953.333, 41.333), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(944, 48), new Point(935.333, 92.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(892.333, 1.333), new Point(844, -1), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(909.333, 62), new Point(920, 90), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(754.334, 39.667), new Point(798.667, 27), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(788.667, 33.333), new Point(790.667, 156), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(808.334, 90), new Point(798, 94), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(806, 90.667), new Point(796.334, 90.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(843, 35.667), new Point(832, 41.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(840.667, 36.667), new Point(838.334, 31.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(797.667, 92.333), new Point(790, 110), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(791, 102.667), new Point(787, 31), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(791.667, 103.333), new Point(790, 129), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(801.667, 91.333), new Point(793.334, 93.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(866.334, 11.667), new Point(785.334, 38.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(879.667, 10.667), new Point(861.667, 13), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(839.334, 33), new Point(792.334, 43), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(819, 28), new Point(839.667, 27.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(835, 44), new Point(787.667, 49.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(832.334, 40.667), new Point(785.334, 44.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(790, 58.333), new Point(831, 50.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(787.334, 64.333), new Point(825.667, 56.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(810.667, 61), new Point(802, 75.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(804.334, 71.333), new Point(798.667, 85.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(798.667, 84.667), new Point(790.667, 92.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(795.334, 64), new Point(792.667, 99.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x63, 0x4F);
            sceneRenderer.DrawLine(new Point(802.334, 53), new Point(798.667, 74.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(794, 150.667), new Point(798, 227.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(801.334, 227.667), new Point(776.334, 228), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(777.334, 229.333), new Point(794, 236.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(791.667, 237), new Point(820, 233), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(817.334, 237), new Point(813.667, 160.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(813.667, 166.333), new Point(810, 139), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(804, 163), new Point(806.667, 232), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(804, 165.667), new Point(798.667, 95.333), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(795.667, 99.667), new Point(795.334, 159), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(803, 76.333), new Point(810.334, 143.333), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(772, 194.333), new Point(774.334, 219.333), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(884, 28), new Point(825.667, 49.667), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(830, 42.333), new Point(823.334, 100), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(816, 97.333), new Point(821, 139), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(824.667, 134), new Point(812, 147), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(895.667, 48), new Point(878, 15), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(892.334, 45.333), new Point(877, 47), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(867.334, 55.667), new Point(831, 67.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(857, 73), new Point(840.667, 72.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(855, 76), new Point(841.334, 81.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(827.334, 98.667), new Point(832.667, 136.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(839, 120.333), new Point(842, 132.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(763.334, 199), new Point(763.334, 210.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(781.667, 188.333), new Point(781.667, 199.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(839, 100.667), new Point(833.334, 111), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(837, 99.667), new Point(831.667, 107), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(846.334, 99.333), new Point(841, 101), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(840.334, 110.667), new Point(835.334, 122.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(841.667, 112), new Point(844.334, 119.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(848.334, 115), new Point(837.334, 119.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(845.667, 127), new Point(855.334, 129.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(856.667, 128.333), new Point(836.334, 134.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(777.667, 191), new Point(768, 195), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(768, 190), new Point(760.667, 199.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(767, 197.333), new Point(760.667, 198.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(762, 195.667), new Point(752, 196), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(757, 192), new Point(746.334, 198), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(781.667, 197.333), new Point(778.667, 207.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(780.334, 203.333), new Point(782, 217), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(781.667, 213), new Point(777.334, 223.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(746.334, 221.333), new Point(765, 225), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(753.334, 221.333), new Point(769.667, 220), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(762.334, 215.667), new Point(771.334, 215.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(762, 208.667), new Point(770.667, 214.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(761, 225), new Point(781.667, 234.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(764.667, 222.667), new Point(779.334, 229.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(770, 219.667), new Point(780, 226), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x62);
            sceneRenderer.DrawLine(new Point(772.667, 218.333), new Point(779.334, 222.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(596.334, 147), new Point(614.668, 169.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(612.668, 169), new Point(610.001, 191), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(607.001, 189), new Point(610.668, 203), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(611.334, 203.667), new Point(601.001, 211), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(606.668, 192.333), new Point(609.334, 185), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(585.001, 207.333), new Point(604.001, 217.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(591.001, 209.333), new Point(607.668, 209.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(604.668, 219.333), new Point(625.001, 209.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(618.668, 161.333), new Point(612.001, 213.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(626.001, 164.667), new Point(620.668, 209.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(632.334, 152.667), new Point(627.334, 217), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(639.334, 149.333), new Point(634.334, 222.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(628.668, 216.667), new Point(623.001, 237.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(633.001, 218), new Point(646.668, 238.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(630.668, 221), new Point(633.668, 250), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(628.001, 235.333), new Point(632.334, 244.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x33, 0x2A);
            sceneRenderer.DrawLine(new Point(634.001, 228), new Point(645.334, 244.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(508.667, 129.667), new Point(503, 148), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(512.333, 133), new Point(511.333, 155.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(504.333, 156), new Point(505.333, 163.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(497.667, 189), new Point(522.333, 190), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(504.667, 186.667), new Point(513, 175.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(512.667, 165), new Point(512.667, 177.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(520.333, 189), new Point(531.333, 186.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(532, 192), new Point(519.667, 194.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(531, 193), new Point(543.333, 176.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(544, 176.333), new Point(544.667, 157.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(545, 158.333), new Point(561, 161.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(564.333, 159.333), new Point(576.667, 157.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(557, 159.667), new Point(567.333, 161.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(573, 160.667), new Point(588, 162), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(584.667, 162), new Point(586.667, 205.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(582, 139.667), new Point(569.667, 140), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(571.667, 140.333), new Point(562.667, 146), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(563.333, 146.333), new Point(556, 133.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(559, 134.667), new Point(562, 125.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(563, 122), new Point(565.667, 125.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(564.667, 123.667), new Point(568.667, 127.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(572.667, 122.667), new Point(576, 128.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(576.333, 125.667), new Point(570.333, 115.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(570.667, 115.667), new Point(538.667, 116.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(538.333, 116.667), new Point(526, 124.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(529.333, 125.333), new Point(525.667, 135.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(526, 134), new Point(510.333, 134), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(512, 150.333), new Point(517.667, 162.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(512.667, 159.333), new Point(516.333, 172), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(508.333, 154.667), new Point(514.667, 169.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(585, 131), new Point(581.333, 138.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(588.667, 128.333), new Point(589, 141.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(567.333, 120), new Point(530.333, 127.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(558, 127.667), new Point(522.667, 137.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(513, 142), new Point(556.333, 134.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(558, 140), new Point(516.667, 150.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(562.667, 147.667), new Point(518.667, 154.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(517.667, 162), new Point(595, 146.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(592.667, 140.667), new Point(559.667, 148.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(540.333, 164.667), new Point(515.667, 169.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(512.333, 178), new Point(541, 173.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(537.667, 180.667), new Point(508, 185.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(573.333, 159.667), new Point(597.333, 153), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(591.667, 155.333), new Point(592, 205.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(599.667, 155.667), new Point(599.333, 206), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x77, 0x5F);
            sceneRenderer.DrawLine(new Point(605, 160.333), new Point(605.333, 209.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(647, 145.333), new Point(665, 145.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(663.333, 145.333), new Point(697.667, 137.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(698, 137.667), new Point(713.667, 139.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(714.333, 139.333), new Point(714.333, 187.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(715.667, 184), new Point(725.667, 151), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(725.667, 152.667), new Point(728, 130.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(728.333, 134), new Point(741.667, 123.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(742, 123.667), new Point(745.667, 123), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(745.667, 122.333), new Point(752, 111.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(752.333, 111.333), new Point(768, 105), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(768.333, 105), new Point(775.333, 92.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(774.667, 94), new Point(782.667, 92.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(788.667, 85.333), new Point(780.667, 91), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(785.333, 85.667), new Point(690.667, 108.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(690.667, 108), new Point(690.667, 119), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(690, 119.667), new Point(685, 129.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(684.333, 126.333), new Point(673.333, 123.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(675.667, 126.667), new Point(678.667, 137), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(676.333, 134), new Point(662.333, 140.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(667.667, 138.333), new Point(646.333, 140), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(769.333, 96), new Point(693.667, 116.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(761, 105), new Point(684.667, 128), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(679.333, 137.667), new Point(745, 116.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(737, 124.667), new Point(706.667, 136.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(718.333, 132.333), new Point(717.333, 159.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(774, 89), new Point(733, 127.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x77, 0x64);
            sceneRenderer.DrawLine(new Point(725.667, 136), new Point(674.667, 137.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(705.333, 138.667), new Point(709.667, 217), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(705, 160), new Point(685.667, 156), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(696.667, 158.667), new Point(683.333, 167.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(687.667, 166.333), new Point(645.333, 160.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(647, 168.667), new Point(688.333, 155), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(702.333, 150), new Point(647.333, 155.333), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(702, 143.333), new Point(646.667, 149.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(662.667, 163.333), new Point(663.667, 207.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(668.333, 165.333), new Point(663.667, 174), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(662.667, 197.333), new Point(652.333, 197), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(651, 194.667), new Point(650.333, 208.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(651, 204.333), new Point(654.667, 215.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(648.667, 206.667), new Point(645, 206.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(646.667, 210.333), new Point(643.667, 211.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(646.667, 199), new Point(644, 199), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(664.333, 187.333), new Point(679.667, 200.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(679.667, 198), new Point(679, 207), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(667.667, 193.333), new Point(672.667, 210), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(662, 205.667), new Point(662, 213), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(664, 207.667), new Point(671.333, 225), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(667.333, 227), new Point(681.667, 219), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(676.667, 204), new Point(676, 219), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(671.667, 206.667), new Point(671.667, 219.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(676.333, 200.667), new Point(673, 213.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(685.333, 222.333), new Point(684.333, 219), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(706, 215.333), new Point(684.667, 220), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(923.333, 129.332), new Point(840.333, 139.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(840, 139.666), new Point(825, 144.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(825.333, 144.999), new Point(824.667, 152.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(824.667, 152.666), new Point(829, 155.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(829, 155.666), new Point(825, 165.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(825.667, 164.999), new Point(829.333, 229.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(829.333, 230.332), new Point(830.667, 241.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(830.667, 241.999), new Point(837.333, 241.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(835.667, 241.666), new Point(834.333, 161.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(835.333, 161.666), new Point(837, 156.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(836, 156.666), new Point(846, 160.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(847.333, 159.999), new Point(849.667, 153.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(850.667, 152.666), new Point(856.667, 159.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(855.667, 159.999), new Point(895.667, 149.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(895.333, 149.666), new Point(905.333, 145.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(905, 145.332), new Point(912.333, 149.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(912.333, 149.999), new Point(912, 192.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(912, 192.999), new Point(908, 199.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(907, 200.332), new Point(900, 198.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(896.667, 196.666), new Point(904.333, 199.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(906, 201.332), new Point(916.667, 207.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(916.667, 141.666), new Point(918.333, 197.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(919.667, 191.999), new Point(916.333, 209.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(913, 204.666), new Point(913, 192.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(915.333, 203.332), new Point(916, 149.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(912, 205.666), new Point(912, 263.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(914, 269.999), new Point(918, 250.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(918.333, 250.332), new Point(918, 199.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(914.333, 206.666), new Point(915.333, 255.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(922.667, 137.332), new Point(928.667, 154.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(925, 140.332), new Point(925, 130.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(924.333, 129.999), new Point(919, 123.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(921, 133.332), new Point(826.333, 148.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(829, 161.666), new Point(832.333, 239.666), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(830.333, 164.332), new Point(835, 148.999), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(836, 154.332), new Point(857.667, 152.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(856, 152.666), new Point(918.333, 139.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(916.333, 146.999), new Point(909, 141.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(925.333, 133.332), new Point(914.333, 140.999), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(873, 275.999), new Point(913.667, 267.666), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(901.667, 278.999), new Point(885.667, 278.332), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(910.333, 266.999), new Point(870.333, 268.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(864.667, 247.666), new Point(868.333, 256.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(866, 253.999), new Point(865, 262.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(865.333, 262.666), new Point(874, 268.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x34, 0x2A);
            sceneRenderer.DrawLine(new Point(878, 284.666), new Point(898, 284.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x53, 0x3F, 0x2E);
            sceneRenderer.DrawLine(new Point(920.333, 124.999), new Point(834.333, 137.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x53, 0x3F, 0x2E);
            sceneRenderer.DrawLine(new Point(835.667, 137.332), new Point(824.667, 140.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x53, 0x3F, 0x2E);
            sceneRenderer.DrawLine(new Point(824.667, 141.332), new Point(816.667, 151.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x53, 0x3F, 0x2E);
            sceneRenderer.DrawLine(new Point(820.333, 145.999), new Point(823.667, 238.666), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1158.001, 20.334), new Point(1128.668, 30.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1137.001, 22.334), new Point(1122.001, 30.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1138.668, 18.334), new Point(1136.001, 20.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1092.001, 19), new Point(1096.335, 27.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1109.001, 24), new Point(1091.668, 30.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1095.001, 23), new Point(1101.335, 26.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1110.001, 22.334), new Point(1103.001, 29), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1101.668, 29.667), new Point(1118.001, 29.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1123.668, 28.667), new Point(1111.001, 30.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1080.001, 32.334), new Point(1098.001, 26), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1083.668, 32), new Point(1081.668, 40), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1080.335, 38.334), new Point(1075.001, 67.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1075.001, 67), new Point(1075.001, 95.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1075.001, 97), new Point(1075.335, 111.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1075.001, 111.667), new Point(1160.335, 73), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1073.335, 93.667), new Point(1076.335, 98), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1075.668, 105), new Point(1163.001, 67.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1084.001, 39), new Point(1080.335, 100), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1088.668, 30), new Point(1089.668, 95.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1087.668, 74.334), new Point(1175.001, 42.334), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1162.668, 31.667), new Point(1086.668, 45.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x99, 0x82);
            sceneRenderer.DrawLine(new Point(1090.335, 36), new Point(1115.001, 44), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7A, 0x68);
            sceneRenderer.DrawLine(new Point(1083.668, -7.333), new Point(1080.001, 20.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7A, 0x68);
            sceneRenderer.DrawLine(new Point(1080.335, 16.667), new Point(1080.001, 99.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7A, 0x68);
            sceneRenderer.DrawLine(new Point(1071.335, 94.667), new Point(1073.335, 112.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7A, 0x68);
            sceneRenderer.DrawLine(new Point(1083.335, 23.333), new Point(1170.001, -3), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x4F, 0x48);
            sceneRenderer.DrawLine(new Point(1157.668, 88.334), new Point(1066.668, 101), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x4F, 0x48);
            sceneRenderer.DrawLine(new Point(1069.001, -2.333), new Point(1068.668, 83.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x4F, 0x48);
            sceneRenderer.DrawLine(new Point(1067.668, 122.334), new Point(1070.335, 93.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x4F, 0x48);
            sceneRenderer.DrawLine(new Point(1059.335, 123), new Point(1067.668, 115.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x4F, 0x48);
            sceneRenderer.DrawLine(new Point(1060.335, 122.667), new Point(1094.335, 117.667), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1068, 125.333), new Point(1068.333, 226.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1048, 123), new Point(1057.667, 126), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1056.667, 126.333), new Point(1065, 132), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1061.333, 125.333), new Point(1165.667, 108.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1068.667, 126.333), new Point(1076.667, 128.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1077.333, 128.667), new Point(1162, 114), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1084, 128.667), new Point(1086, 132.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1085.667, 132.667), new Point(1172.333, 118.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1145, 126), new Point(1146.333, 133.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1143.333, 137), new Point(1147.667, 137), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1156, 125), new Point(1145, 127.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1071, 230.667), new Point(1065.333, 237.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1068.667, 234), new Point(1068.333, 245.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x2E, 0x25);
            sceneRenderer.DrawLine(new Point(1070, 224), new Point(1070, 232.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1074.333, 129.667), new Point(1090.667, 136.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1082, 139.333), new Point(1096.333, 140.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1090, 137.667), new Point(1146.333, 128.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1094, 143), new Point(1167, 128.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1093.333, 149.333), new Point(1166, 134), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1094.333, 156.667), new Point(1163.333, 135.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1113.333, 148.667), new Point(1095.333, 155), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1096.333, 162.333), new Point(1132.333, 147.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1109.667, 162.667), new Point(1098.333, 163), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1108, 161.667), new Point(1119, 153.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1147, 142.333), new Point(1139.667, 148), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1140.667, 151.667), new Point(1146.667, 149.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1146.333, 155.667), new Point(1142.667, 155.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1143, 158.667), new Point(1146.333, 158.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1098.333, 172.333), new Point(1096.333, 250), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1108.667, 173.667), new Point(1105.667, 262.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1106.333, 263.667), new Point(1092.667, 264.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1095.667, 264.333), new Point(1093.333, 256.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1094, 260.667), new Point(1096.667, 241.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1103.333, 170.667), new Point(1100, 263.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x4E, 0x39);
            sceneRenderer.DrawLine(new Point(1104.333, 175), new Point(1110.333, 173.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1091, 139.667), new Point(1092, 268), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1159, 146.333), new Point(1098.667, 153.333), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1113.667, 166.333), new Point(1106, 176), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(973.334, 32.001), new Point(978.334, 26.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(984.667, 18.001), new Point(976.334, 23.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(996.001, 10.001), new Point(982.001, 16.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(991.334, 18.334), new Point(1010.001, 13.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(994.001, 14.334), new Point(1017.334, 8.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(995.001, 24.334), new Point(1026.334, 20.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(999.334, 20.001), new Point(1019.334, 20.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1013.667, 27.001), new Point(1032.001, 21.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1025.667, 26.668), new Point(1040.334, 26.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1029.667, 29.668), new Point(1021.001, 34.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1020.334, 38.334), new Point(1049.667, 34.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1047.001, 33.334), new Point(1038.667, 31.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1045.001, 31.334), new Point(1057.667, 26.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1053.334, 29.668), new Point(1060.334, 32.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1060.001, 28.668), new Point(1061.667, 50.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1062.334, 46.668), new Point(1061.667, 75.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1063.667, 45.334), new Point(1061.001, 2.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1025.667, 35.668), new Point(1046.667, 29.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1023.667, 34.334), new Point(1041.667, 26.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1059.667, 31.334), new Point(1055.334, -4.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1063.001, 7.001), new Point(1057.667, -5.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1065.001, 2.001), new Point(967.001, 2.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(968.001, 7.334), new Point(1057.334, 7.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1056.001, 9.334), new Point(966.667, 12.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(972.001, 11.668), new Point(977.334, 25.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(977.334, 9.001), new Point(979.667, 21.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1057.667, 16.334), new Point(1005.667, 16.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x6C, 0x4D);
            sceneRenderer.DrawLine(new Point(1060.001, 23.001), new Point(1027.334, 24.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(969.334, 76.001), new Point(1015.001, 66.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1002.667, 76.001), new Point(1017.667, 72.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1020.001, 75.334), new Point(1010.001, 78.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1001.001, 84.001), new Point(1023.667, 77.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1021.334, 82.334), new Point(1006.667, 87.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1009.334, 89.668), new Point(1027.334, 87.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1028.667, 89.668), new Point(1004.001, 98.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1015.001, 98.001), new Point(1042.334, 94.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1022.334, 101.001), new Point(1064.001, 94.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1067.001, 98.334), new Point(1055.334, 102.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1057.667, 102.001), new Point(1022.334, 108.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1017.334, 108.668), new Point(1024.334, 108.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1030.001, 112.668), new Point(1068.334, 103.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1066.334, 106.668), new Point(1049.334, 112.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1053.667, 112.001), new Point(1070.001, 112.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1066.001, 114.334), new Point(1050.001, 123.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1061.667, 118.668), new Point(1053.001, 122.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1057.334, 123.334), new Point(1040.001, 123.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(995.334, 74.334), new Point(1021.667, 67.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1066.001, 134.001), new Point(1055.667, 134.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1055.667, 138.668), new Point(1067.667, 138.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1066.334, 139.668), new Point(1050.667, 147.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1033.334, 147.334), new Point(1063.667, 147.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1064.334, 143.668), new Point(1053.667, 149.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1040.334, 151.668), new Point(1061.334, 151.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1061.667, 154.001), new Point(1039.667, 161.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1033.001, 160.668), new Point(1054.334, 157.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1059.667, 161.334), new Point(1036.667, 166.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1059.001, 159.334), new Point(1045.667, 162.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1037.001, 174.001), new Point(1054.334, 170.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1032.334, 182.334), new Point(1054.667, 173.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1044.001, 168.668), new Point(1059.001, 168.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1030.334, 185.668), new Point(1051.667, 185.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1021.001, 196.001), new Point(1051.667, 192.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1028.667, 190.001), new Point(1053.667, 189.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1040.001, 195.334), new Point(1036.334, 206.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1036.001, 206.334), new Point(1027.001, 207.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1031.001, 207.334), new Point(1017.334, 216.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1016.667, 211.334), new Point(1032.001, 203.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1030.667, 203.001), new Point(1031.667, 195.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1028.001, 196.334), new Point(1023.667, 207.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1023.001, 197.334), new Point(1020.667, 203.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1009.001, 223.668), new Point(1039.001, 215.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1012.334, 219.001), new Point(1042.334, 213.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1027.001, 219.001), new Point(1051.001, 224.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1037.667, 226.668), new Point(1054.001, 226.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1048.334, 217.668), new Point(1062.667, 229.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1032.667, 217.334), new Point(1056.334, 221.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1027.667, 212.001), new Point(1044.334, 207.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1036.667, 193.334), new Point(1032.667, 205.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1039.001, 182.668), new Point(1060.334, 176.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1047.001, 182.668), new Point(1058.667, 182.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1049.001, 178.668), new Point(1051.334, 221.334), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1059.334, 140.668), new Point(1058.334, 202.001), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1033.334, 28.001), new Point(1044.334, 96.001), brush, 50f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1032.001, 48.334), new Point(975.667, 31.668), brush, 50f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8F, 0x77);
            sceneRenderer.DrawLine(new Point(1004.334, 57.334), new Point(970.001, 64.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(958.75, 159.75), new Point(972.75, 225.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(958.75, 210.5), new Point(974.75, 256.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(972.5, 206.75), new Point(979.75, 237.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(998.25, 201.5), new Point(989, 233), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(998.25, 199.5), new Point(995.5, 232.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1002.75, 213.25), new Point(995.75, 238.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1004.75, 210.75), new Point(999.25, 236.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(995, 224.75), new Point(988.25, 237.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1006.25, 221.25), new Point(1003.5, 236.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1009.5, 217.5), new Point(1018.25, 209.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1007.5, 226), new Point(1019.75, 231.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1008.5, 226.25), new Point(1028, 223.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1024.25, 223.5), new Point(1040, 226.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1014.75, 227), new Point(1025, 236.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(1003.75, 232), new Point(1014, 235.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(955.5, 241.75), new Point(962, 281.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(975.5, 252), new Point(960.5, 273.75), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x4C, 0x44, 0x3C);
            sceneRenderer.DrawLine(new Point(999.75, 247.25), new Point(992.75, 258.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1076.75, 127.5), new Point(1077.75, 263.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1015.75, 227), new Point(1069.75, 234.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1071, 225), new Point(1042, 220.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1065.5, 237.25), new Point(1060.75, 255.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1038.75, 235.75), new Point(1049, 244), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1048.5, 244), new Point(1049.75, 247.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1051.75, 244.75), new Point(1055, 237.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1058, 254.25), new Point(1065.5, 270.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x72, 0x57);
            sceneRenderer.DrawLine(new Point(1069.25, 246.75), new Point(1069, 258.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(970.75, 276), new Point(977.75, 278), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(974, 278), new Point(983.5, 267.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(985.25, 263.25), new Point(974.75, 271), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(977.5, 270.25), new Point(987.25, 262), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(987.5, 261.5), new Point(992.25, 267.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(991.75, 267.5), new Point(988.25, 272.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(989, 272.75), new Point(994.75, 272.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(995, 269.25), new Point(998.25, 274.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(999, 277.5), new Point(999, 269.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(993.5, 264.5), new Point(999.5, 270.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(990.25, 265.25), new Point(998.5, 273.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1003.5, 262.75), new Point(986.75, 265), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1049.25, 246.75), new Point(1049, 254.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1049.25, 254.5), new Point(1051, 258), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1050.75, 257), new Point(1050, 268.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1049.5, 268.25), new Point(1047, 277.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1041.5, 253.5), new Point(1042, 258.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1043, 256.75), new Point(1045.25, 266), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1045, 265), new Point(1045, 275.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3D, 0x3F, 0x2A);
            sceneRenderer.DrawLine(new Point(1052.75, 262.5), new Point(1056.5, 273.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1115, 170.75), new Point(1113.25, 247.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1118, 178.5), new Point(1160.5, 173.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1149.5, 180.25), new Point(1158.25, 188.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1117, 217.25), new Point(1127.75, 220.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1125, 220), new Point(1132.5, 233.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1130.5, 230.75), new Point(1138, 240.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1135, 238.75), new Point(1145.25, 241.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1144.75, 241.25), new Point(1160.5, 242), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1154, 240.5), new Point(1155.5, 258), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1127.25, 217), new Point(1132, 229.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1129.25, 218.25), new Point(1147.5, 218.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1146, 218.5), new Point(1160.5, 223.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1134.5, 218.75), new Point(1142, 223), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1141, 221.75), new Point(1144.25, 229.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1143.5, 227.5), new Point(1154, 230.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1151.5, 229.5), new Point(1158.75, 233.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1141.25, 222), new Point(1159.25, 230), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1142.5, 220.25), new Point(1160.75, 227.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1146.25, 218), new Point(1164.5, 225), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1110.5, 244.5), new Point(1109.25, 261.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1115, 245.75), new Point(1111.5, 252.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1116.25, 246), new Point(1120.5, 254), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1120.5, 251.25), new Point(1121.25, 260.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1121.75, 259.25), new Point(1123.25, 263.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1123, 256.5), new Point(1124.75, 243.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1120, 237.75), new Point(1122.75, 252), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1125, 246), new Point(1121, 240.25), brush, 5f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(1126.5, 202.875);
                ellipse.RadiusX = 5f;
                ellipse.RadiusY = 3.625f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(1128.75, 211.875);
                ellipse.RadiusX = 6f;
                ellipse.RadiusY = 5.625f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(1146.75, 188.25);
                ellipse.RadiusX = 7.25f;
                ellipse.RadiusY = 8f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1147.75, 189.25), new Point(1118, 189.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x7A, 0x7B, 0x74);
            sceneRenderer.DrawLine(new Point(1119.25, 195.5), new Point(1126.75, 219.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x61, 0x56);
            sceneRenderer.DrawLine(new Point(1131.75, 220.5), new Point(1143.75, 237.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x61, 0x56);
            sceneRenderer.DrawLine(new Point(1140.25, 232.75), new Point(1168.5, 240), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1023.25, 300.25), new Point(1047.75, 301), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1045.5, 301), new Point(1054, 298.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1029.5, 289), new Point(1034.25, 292.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1033.75, 291), new Point(1047.75, 292.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1036.25, 286.75), new Point(1067.25, 286.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1047.25, 304), new Point(1065.5, 288.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1045.5, 294), new Point(1064.25, 291.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1041.5, 282.75), new Point(1071.25, 278.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1061.25, 279.5), new Point(1159.25, 267.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1092.25, 278), new Point(1062.5, 290), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1081, 282.75), new Point(1113.5, 283), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1106.75, 282), new Point(1162, 275.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1113.5, 283.25), new Point(1166, 282.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1110.5, 290.5), new Point(1130.25, 284.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1111.75, 291), new Point(1098.75, 285), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF3, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(1115.75, 288.75), new Point(1105.75, 287.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1079.5, 287.25), new Point(1099.75, 287.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1096, 287.25), new Point(1112.25, 293.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1104.25, 290.75), new Point(1117.5, 299), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1113.25, 293.75), new Point(1121.5, 306), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1121.5, 305), new Point(1125, 312.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1124, 311.75), new Point(1126.5, 315), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1124.25, 313.25), new Point(1134.5, 316.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1133.75, 316.5), new Point(1134.75, 312.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1134.25, 312), new Point(1140, 310), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1140.25, 310), new Point(1160.5, 308.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1134.25, 311.25), new Point(1122.75, 308.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1119, 305.5), new Point(1159.75, 305.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1156.5, 297), new Point(1114.25, 296.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1110.25, 291), new Point(1165, 289.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x8C, 0x8D);
            sceneRenderer.DrawLine(new Point(1124.75, 319.5), new Point(1141.75, 326.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x8C, 0x8D);
            sceneRenderer.DrawLine(new Point(1139.25, 326), new Point(1161.75, 326), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x8C, 0x8D);
            sceneRenderer.DrawLine(new Point(1123.5, 316.5), new Point(1163, 316.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x8C, 0x8D);
            sceneRenderer.DrawLine(new Point(1140.5, 310.75), new Point(1156.25, 311), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x45, 0x45, 0x43);
            sceneRenderer.DrawLine(new Point(1127.25, 339.75), new Point(1160.5, 339.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x45, 0x45, 0x43);
            sceneRenderer.DrawLine(new Point(1129.75, 325.5), new Point(1130.75, 338.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x45, 0x45, 0x43);
            sceneRenderer.DrawLine(new Point(1133.25, 333.5), new Point(1158, 335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1077, 289.5), new Point(1067.25, 297.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1067, 297.25), new Point(1065.25, 303), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1065.25, 303.25), new Point(1067.25, 305), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1066.25, 305), new Point(1076.5, 301.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1074, 303), new Point(1090, 294.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1067.25, 301.5), new Point(1084, 291.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1075.5, 292.25), new Point(1088.25, 289), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1085.75, 291.5), new Point(1101.25, 292.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1087.25, 295.25), new Point(1104.25, 295.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1100, 296.25), new Point(1112.25, 302.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1102, 292.75), new Point(1120, 304), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1104.5, 300.25), new Point(1105.25, 307.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1105.25, 305.75), new Point(1117.75, 314.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1107.25, 300.75), new Point(1122.5, 312.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1116.75, 310.75), new Point(1123, 329.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1121.5, 312), new Point(1125.25, 345.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1121.5, 321.25), new Point(1119, 346.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1119.75, 341.75), new Point(1112.25, 355.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1102.5, 356.25), new Point(1143, 358.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1133.75, 357.5), new Point(1160.5, 357.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x16, 0x17, 0x17);
            sceneRenderer.DrawLine(new Point(1115.25, 349.75), new Point(1159.5, 349), brush, 18f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(1096, 328.375);
                ellipse.RadiusX = 22.5f;
                ellipse.RadiusY = 22.125f;
                brush.Color = Color.FromArgb(0xFF, 0xC1, 0xC5, 0xCC);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x67, 0x62);
            sceneRenderer.FillRectangle(new Rect(879, 209.665, 32.667, 47.5), brush);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1023, 340.75), new Point(1031.5, 347.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1025.25, 341.25), new Point(1063.75, 341.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1063, 340.5), new Point(1059.25, 336.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1059.75, 336), new Point(1049.25, 336), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1050.25, 336.5), new Point(1042, 332), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1046, 333.5), new Point(1049.75, 332), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1048.5, 331.75), new Point(1053.75, 311.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1053.75, 311.25), new Point(1056.75, 302.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1057, 302.5), new Point(1068.5, 292.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1030.25, 347.5), new Point(1045.25, 348.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1045.5, 348.5), new Point(1070.5, 355.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1070.25, 355.75), new Point(1082.75, 356.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1083.25, 356.75), new Point(1111, 355.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1027.25, 343), new Point(1075.25, 346.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1062.75, 296.25), new Point(1052.75, 335), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1069, 300.75), new Point(1059.5, 337.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1075.75, 300.75), new Point(1066, 340.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1073, 314.5), new Point(1089.5, 294.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1080, 306.5), new Point(1099.25, 298.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1089.25, 299.75), new Point(1109.5, 302.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1053.25, 347.5), new Point(1084.25, 353), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1081.5, 354.75), new Point(1113.5, 352.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1108, 352.75), new Point(1119, 341), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1066, 334.5), new Point(1077.75, 351.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1068.75, 322.25), new Point(1070, 346.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x36, 0x36, 0x37);
            sceneRenderer.DrawLine(new Point(1065.5, 333.75), new Point(1064.75, 347), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x73, 0x5C);
            sceneRenderer.FillRectangle(new Rect(880.5, 172.666, 31.333, 29.5), brush);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1024, 297.5), new Point(1021.25, 306.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1021.5, 303.25), new Point(1026.25, 317.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1026.5, 315.25), new Point(1024.5, 323.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1020.75, 321.5), new Point(1036, 325.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1034.75, 325.25), new Point(1049, 326), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1051.5, 302.75), new Point(1046, 323.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1043.75, 303.5), new Point(1039.25, 323.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1036.75, 301.75), new Point(1032, 321.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0xBF, 0xBD);
            sceneRenderer.DrawLine(new Point(1028.25, 302), new Point(1028.5, 315.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(954, 316.5), new Point(938, 315.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(939.5, 314.75), new Point(924, 310), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(925.25, 311.5), new Point(920, 313.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(921.25, 314.5), new Point(902.25, 309), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(902, 309), new Point(874.25, 307), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(876, 307.5), new Point(863.5, 301.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(951, 312.75), new Point(1025.25, 317), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(1017.5, 319.5), new Point(1022.5, 319.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(1022, 310), new Point(876, 299.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(781.25, 297.5), new Point(807.5, 298), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(780, 296), new Point(802, 293.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(799.25, 293.5), new Point(813.75, 297.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(806.5, 298.5), new Point(847.25, 293.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(843.25, 293), new Point(869.25, 290.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(842.25, 290), new Point(827.5, 295.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(810, 287.75), new Point(828.75, 286), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(830.75, 285.25), new Point(822.75, 291.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(826.75, 290.5), new Point(809.25, 291.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(808.5, 293.75), new Point(826.75, 295), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(858.5, 302.25), new Point(864.5, 301.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(867, 297.75), new Point(860.5, 300.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(856.75, 307.5), new Point(873.75, 309.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(866, 289), new Point(875.5, 284), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(875.25, 284), new Point(875.5, 303.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(870.25, 288.25), new Point(870.75, 303.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(868, 293.25), new Point(867, 299.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(875.75, 288.5), new Point(902.5, 289), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(905.75, 278), new Point(898.5, 288), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(909.5, 278), new Point(903.25, 280.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x7B, 0x73);
            sceneRenderer.DrawLine(new Point(915.25, 290), new Point(896, 291.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x49, 0x45, 0x33);
            sceneRenderer.DrawLine(new Point(928.5, 171.75), new Point(919.25, 212.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x49, 0x45, 0x33);
            sceneRenderer.DrawLine(new Point(927.75, 208), new Point(925.5, 288.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x49, 0x45, 0x33);
            sceneRenderer.DrawLine(new Point(934, 274.75), new Point(898.25, 281.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x49, 0x45, 0x33);
            sceneRenderer.DrawLine(new Point(927.5, 184), new Point(926.5, 213), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB8, 0xBC, 0xA0);
            sceneRenderer.DrawLine(new Point(1157.668, 260.333), new Point(1044.001, 277), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB8, 0xBC, 0xA0);
            sceneRenderer.DrawLine(new Point(1045.668, 277), new Point(1034.668, 282.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB8, 0xBC, 0xA0);
            sceneRenderer.DrawLine(new Point(1037.001, 279.333), new Point(1025.001, 298.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB8, 0xBC, 0xA0);
            sceneRenderer.DrawLine(new Point(1028.335, 295), new Point(1039.335, 295), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.FillRectangle(new Rect(898.334, -4.329, 34.333, 44.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(864.833, 196.667), new Point(836.333, 198.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(852.333, 198.5), new Point(852.167, 203.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(851.833, 202.5), new Point(852.333, 207.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(852.333, 204.667), new Point(849.333, 209.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(850.833, 206.5), new Point(845.667, 209.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(846.5, 208.833), new Point(835.333, 209.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(851, 202.167), new Point(836.5, 204.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(866.167, 191), new Point(835.333, 194.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(836.5, 190), new Point(866.333, 185.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(834, 179.333), new Point(842.833, 179.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(840.667, 179.333), new Point(851.5, 186.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(846.167, 183.667), new Point(835.167, 185), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(853.333, 186.167), new Point(860.833, 174.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(859, 180.333), new Point(867, 183.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(859.667, 179.5), new Point(876.333, 177), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(860.5, 176.333), new Point(872.167, 173), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(872.5, 176.167), new Point(878.667, 167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(876, 173), new Point(876, 179), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(877.667, 163.333), new Point(881.667, 168), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(881.667, 160.167), new Point(884.5, 163.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(886.667, 158), new Point(888.167, 161.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(889.5, 156.5), new Point(892.333, 161.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(895.333, 155), new Point(896.833, 160.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(896.167, 150.333), new Point(902, 161.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(899.333, 149.167), new Point(908.5, 162.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(903.667, 147.333), new Point(910.833, 161.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x74, 0x72, 0x5F);
            sceneRenderer.DrawLine(new Point(907.5, 149.5), new Point(911.5, 153.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(878.167, 177.333), new Point(890, 178.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(888.667, 178.667), new Point(890.833, 184.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(887.5, 183.5), new Point(897.167, 179.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(894.5, 178.667), new Point(906.5, 175), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(903.167, 175.333), new Point(908.167, 181.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(907.333, 178.833), new Point(910, 192.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(911, 166.833), new Point(880.5, 166.667), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xD8, 0xC4, 0x8B);
            sceneRenderer.DrawLine(new Point(912.167, 173.833), new Point(877.5, 173.667), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x72, 0x59);
            sceneRenderer.DrawLine(new Point(832.667, 174.167), new Point(897.667, 151.167), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(842.833, 210.665), new Point(843.5, 218.165), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(843.5, 218.332), new Point(845, 222.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(845.167, 222.999), new Point(851.333, 225.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(850, 225.165), new Point(855.833, 227.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(854.833, 227.165), new Point(855.5, 235.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(855.333, 235.832), new Point(860.167, 237.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(859.833, 237.832), new Point(864.167, 240.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(862, 240.499), new Point(862, 247.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(882.667, 265.332), new Point(887.833, 256.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(887, 256.665), new Point(880.333, 254.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(881.667, 255.332), new Point(882.5, 249.165), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(883.333, 243.832), new Point(883, 248.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(877.5, 240.665), new Point(878.333, 244.165), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(878.5, 235.665), new Point(878.667, 239.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(883.5, 234.499), new Point(883.167, 239.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(887.833, 237.832), new Point(887.5, 239.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(891.333, 239.332), new Point(891.5, 241.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(894, 238.332), new Point(893.667, 240.165), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(891.667, 222.665), new Point(888.5, 229.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(895.167, 222.832), new Point(892.333, 228.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(888, 228.499), new Point(883.667, 233.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(888.833, 224.499), new Point(882, 215.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(884.667, 218.499), new Point(885, 207.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(884.667, 208.332), new Point(897.5, 207.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(894.5, 207.999), new Point(901.333, 212.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(901.167, 212.165), new Point(904.5, 208.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(904.667, 209.499), new Point(909.333, 212.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(909.333, 212.832), new Point(906.833, 221.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(903.667, 224.332), new Point(911.5, 219.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(910.5, 208.332), new Point(892.333, 198.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(895.667, 199.165), new Point(889.167, 194.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(892.333, 195.665), new Point(889.667, 187.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(891, 192.332), new Point(899.5, 196.832), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(888.833, 189.499), new Point(881.667, 189.499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(883.167, 188.832), new Point(879.5, 175.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(905.333, 209.165), new Point(862.167, 193.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(876.667, 266.499), new Point(861.667, 194.832), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(871.667, 178.165), new Point(875.833, 198.832), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(888.5, 191.499), new Point(885.333, 202.165), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(884.5, 199.332), new Point(855.167, 223.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(848.333, 207.332), new Point(853.167, 224.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(859.833, 220.832), new Point(864.667, 235.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(876.667, 205.665), new Point(876.333, 238.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x41, 0x39);
            sceneRenderer.DrawLine(new Point(882.833, 221.499), new Point(882.833, 230.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);
            sceneRenderer.DrawLine(new Point(913.333, 241.998), new Point(895.667, 252.498), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);
            sceneRenderer.DrawLine(new Point(898, 249.832), new Point(894.667, 254.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);
            sceneRenderer.DrawLine(new Point(894.667, 254.665), new Point(890.833, 259.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);
            sceneRenderer.DrawLine(new Point(890.833, 259.665), new Point(912.5, 252.832), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);
            sceneRenderer.DrawLine(new Point(911.167, 259.165), new Point(878.167, 263.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(673.5, 258.5), new Point(639.5, 261.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(670.5, 258.5), new Point(690, 257.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(684, 263.75), new Point(726, 261.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(746.75, 254.25), new Point(687.75, 257.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(745.75, 253.5), new Point(757.25, 239.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(752.5, 228.5), new Point(754.25, 241.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(755.25, 230), new Point(787, 251.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(755.5, 240.25), new Point(798, 267.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(791.75, 250.25), new Point(795.75, 265.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(737.5, 266.25), new Point(745, 274.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(739.5, 261.5), new Point(751.5, 261.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(745, 257.5), new Point(764.5, 246), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(775, 278.25), new Point(791.75, 264.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(743.25, 272.75), new Point(759.25, 269.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(759.25, 269.5), new Point(767, 270), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(764.5, 270), new Point(772.25, 275), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(769.25, 273.25), new Point(778, 278.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(743.5, 268.25), new Point(769.5, 253.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(765, 256.5), new Point(784.75, 269), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(753.75, 264.75), new Point(778.25, 267.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(738.5, 269), new Point(630.75, 270.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(688.75, 268), new Point(731.5, 266.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(725.5, 258), new Point(728, 265.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(729.5, 257.5), new Point(727.5, 263.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(644, 246.5), new Point(657.75, 235.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(657.75, 235.75), new Point(673.5, 229.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(673.5, 229.25), new Point(688.75, 224), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(688.75, 224), new Point(702.25, 220.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(696.25, 223), new Point(717.75, 220.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(717.75, 220), new Point(733.75, 221.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(733.75, 221.25), new Point(742.5, 225.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(742.75, 226), new Point(751.25, 232), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(701, 220.5), new Point(719.5, 218.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(717.75, 218.5), new Point(732.5, 219), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(732, 219), new Point(748.75, 224), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(749, 224), new Point(763, 229.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(739.5, 223.5), new Point(755.75, 229.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(782.5, 244.5), new Point(801.75, 247.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(802, 247.25), new Point(824, 248.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(824, 248.25), new Point(834.5, 248), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(834.75, 248), new Point(833.5, 254.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(833.25, 254.5), new Point(828, 257.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(828, 257.75), new Point(822.5, 257.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(822, 258.25), new Point(819.5, 257.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(821.5, 257.75), new Point(814.75, 249.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(808.25, 248.5), new Point(798.25, 250.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(800.5, 249.25), new Point(794.75, 257.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(818.25, 254.25), new Point(833.75, 251.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(821, 251), new Point(815.75, 252.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(799, 250.25), new Point(781.5, 250.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(784.5, 251), new Point(802.75, 273), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(792.5, 272), new Point(830, 273.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(796.25, 265), new Point(816, 271.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(815.25, 268), new Point(834.75, 276.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(829.5, 276.5), new Point(810.5, 282.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(805.75, 276.5), new Point(820, 279.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(673, 266.75), new Point(630, 266.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(624, 260.25), new Point(638, 254.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(622, 255.25), new Point(638.5, 249.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(637.75, 248.75), new Point(638, 258.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(640.5, 259.25), new Point(628.75, 263), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF1, 0xF1, 0xF3);
            sceneRenderer.DrawLine(new Point(626.75, 260), new Point(630.75, 268.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(671.75, 298.25), new Point(734.25, 297.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(711, 299.75), new Point(734.5, 300.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(825.25, 268.25), new Point(851.5, 267.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(850.25, 268), new Point(864.25, 263.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(838.75, 265.5), new Point(859.5, 257.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(845.75, 264.25), new Point(859, 262.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(859.75, 261.5), new Point(863, 251), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(857, 247.5), new Point(856.5, 257.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(859, 252.75), new Point(860.25, 247.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(858.75, 247), new Point(842.25, 244.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(842.5, 246.5), new Point(826.5, 247), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(841.25, 276.75), new Point(846.75, 274.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(845.5, 274.5), new Point(851.25, 275), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(856.75, 275.25), new Point(850.5, 277.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(854.5, 275.5), new Point(848.5, 275.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(852, 277), new Point(843.25, 278.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(860.25, 273), new Point(860.5, 287.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(860.75, 273.75), new Point(869, 266.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(861.75, 272.75), new Point(863.25, 288), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(866.25, 269.25), new Point(868.25, 285.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x94, 0x9D);
            sceneRenderer.DrawLine(new Point(884.25, 279.25), new Point(868.25, 282.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x93, 0x9C);
            sceneRenderer.DrawLine(new Point(94.334, 288.335), new Point(-4.333, 300.335), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x93, 0x9C);
            sceneRenderer.DrawLine(new Point(121, 316.335), new Point(-5, 336.668), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x93, 0x9C);
            sceneRenderer.DrawLine(new Point(144.334, 340.001), new Point(-17.666, 358.668), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(761.25, 227.75), new Point(789.25, 242.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(788.5, 242.75), new Point(846, 244.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(804, 239), new Point(829.75, 239), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(821.5, 263), new Point(857, 252), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(853.25, 246.5), new Point(821, 257.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(856.75, 258.25), new Point(822, 268.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(776.5, 275.5), new Point(783.5, 293.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(777.75, 286), new Point(870.25, 274.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(637.5, 290.5), new Point(730.75, 289.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(632.25, 275.25), new Point(730.5, 272.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(730.25, 271.5), new Point(739, 278.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(738.5, 278.5), new Point(735.25, 289), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(735.5, 289), new Point(731.5, 296.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(731.75, 296.75), new Point(731.25, 275), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(734.25, 276.25), new Point(735, 284.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(729, 219.25), new Point(763.75, 219.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(651, 247.5), new Point(670.5, 247.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(669.25, 247.25), new Point(683.5, 245.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(683.75, 245.75), new Point(696.25, 247.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(696.5, 247.5), new Point(700.25, 250.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(699.5, 250.25), new Point(679.5, 252.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(692.75, 248.5), new Point(662.25, 250.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(669.5, 250), new Point(685.25, 252.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(651.5, 248.5), new Point(657.75, 255), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(654.25, 250.75), new Point(664.75, 252), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(653.75, 254.75), new Point(680, 252.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(694.5, 247), new Point(698.25, 248.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(699.25, 251), new Point(742.75, 248.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(744.75, 247.5), new Point(715.25, 243.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(703.5, 242.5), new Point(720.75, 243.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(702.5, 247.25), new Point(721.75, 246.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xBB, 0xBC, 0xC7);
            sceneRenderer.DrawLine(new Point(741, 242.75), new Point(707.5, 245), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(741.335, 297), new Point(741.335, 304.333), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(741.002, 302.667), new Point(742.502, 309.333), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(740.502, 307), new Point(744.335, 314.833), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(744.169, 314.333), new Point(747.002, 318.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(745.002, 316.5), new Point(749.502, 319.833), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(746.502, 317.333), new Point(751.669, 320.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(748.002, 319.667), new Point(756.669, 320.667), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(754.835, 320.667), new Point(764.169, 319.667), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(746.502, 286.167), new Point(741.335, 298.667), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(746.335, 288.5), new Point(752.169, 283.167), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(750.335, 283.5), new Point(758.335, 282.167), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(757.002, 282.167), new Point(764.669, 284.167), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(763.169, 283.5), new Point(770.835, 288.333), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(769.502, 286.833), new Point(771.502, 294.167), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(770.169, 291.5), new Point(772.835, 299.667), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(773.502, 296.833), new Point(772.002, 306.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(772.335, 305.333), new Point(769.169, 313), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(770.169, 311.833), new Point(764.835, 319.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(762.002, 320.667), new Point(767.169, 318.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x44, 0x46);
            sceneRenderer.DrawLine(new Point(761.835, 284.167), new Point(769.669, 292.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(675.001, 313), new Point(744.335, 317.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(741.668, 312), new Point(679.168, 309.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(681.168, 308.5), new Point(678.001, 312.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(739.168, 304.833), new Point(738.501, 292.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(738.001, 293.167), new Point(741.835, 281.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(742.168, 283), new Point(751.668, 277.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(739.001, 280.333), new Point(747.668, 275.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(749.335, 278.333), new Point(762.001, 276.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(760.668, 276.167), new Point(774.335, 282.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(773.501, 282.833), new Point(778.835, 300.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(778.168, 300.333), new Point(786.501, 307.833), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(777.501, 298.833), new Point(776.668, 312), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(775.835, 309.333), new Point(770.168, 320.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(766.001, 320.333), new Point(788.335, 320.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(781.335, 319.833), new Point(832.168, 320.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(774.168, 316.5), new Point(873.335, 313.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(859.168, 314), new Point(869.835, 318), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(872.668, 314.167), new Point(869.501, 317.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(862.335, 310), new Point(845.668, 313.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(844.501, 308.833), new Point(828.501, 314), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(840.668, 308.667), new Point(773.335, 311.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(780.001, 305.833), new Point(842.835, 304.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(848.001, 302.333), new Point(840.168, 306), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x22, 0x21, 0x1F);
            sceneRenderer.DrawLine(new Point(847.001, 302.333), new Point(840.668, 304), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(-7, 262.001), new Point(58.667, 255.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(55.334, 256.335), new Point(71.667, 256.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(70.667, 256.335), new Point(83, 258.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(79.667, 257.335), new Point(96, 273.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(92.667, 267.668), new Point(108, 286.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(105, 284.668), new Point(66.334, 284.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(73.667, 284.001), new Point(39.667, 288.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(40, 291.668), new Point(-9, 288.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(23.334, 290.668), new Point(-20.333, 297.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(96.667, 274.668), new Point(0, 286.335), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(86.334, 263.335), new Point(-7.333, 275.001), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(0, 304.335), new Point(40.667, 301.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(39, 297.001), new Point(80.334, 296.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(112, 291.335), new Point(68.667, 296.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(105.334, 287.335), new Point(123, 301.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(-2.666, 324.668), new Point(32, 320.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(27.667, 320.001), new Point(38.334, 324.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(37, 323.668), new Point(49, 321.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(47.667, 321.001), new Point(86.667, 314.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(72.667, 316.001), new Point(96.334, 317.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(94, 319.001), new Point(109.334, 309.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(107.334, 309.001), new Point(118.667, 309.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(122.334, 299.668), new Point(127, 311.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(126.667, 307.335), new Point(111.334, 308.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(117.667, 295.668), new Point(29.334, 305.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(-1, 312.335), new Point(119.334, 301.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(104.667, 311.335), new Point(-7, 317.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(94, 367.335), new Point(-6.333, 382.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(4.667, 383.001), new Point(71.667, 376.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(71.334, 376.668), new Point(144, 361.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(89.667, 367.001), new Point(144.334, 356.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(146, 337.001), new Point(148.334, 350.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(148.334, 346.668), new Point(141.334, 360.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(13, 366.001), new Point(48.667, 362.335), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(32.667, 366.001), new Point(75.667, 359.335), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(46, 360.668), new Point(54.667, 360.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(59.667, 355.335), new Point(75.334, 359.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(92, 352.001), new Point(69.334, 362.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(74.667, 361.001), new Point(106.667, 353.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1A, 0x1C, 0x1B);
            sceneRenderer.DrawLine(new Point(131.667, 346.335), new Point(97.667, 356.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(67.667, 341.001), new Point(53, 346.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(63.667, 342.001), new Point(10.667, 346.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(10.667, 346.668), new Point(0, 350.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(1, 349.668), new Point(24.667, 347.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(25, 347.335), new Point(60, 344.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(56, 344.668), new Point(58.667, 352.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(58.667, 353.001), new Point(64.667, 360.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(59.334, 345.335), new Point(62.334, 354.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(75.667, 339.335), new Point(91.667, 340.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(81.334, 338.668), new Point(108.334, 334.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(93.667, 337.001), new Point(91, 347.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(90, 339.668), new Point(93, 352.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(104.667, 335.001), new Point(146, 329.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(145.334, 326.335), new Point(111, 334.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(144, 320.668), new Point(144, 336.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(144.667, 323.668), new Point(149.334, 334.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(149.334, 332.668), new Point(150, 343.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x4B, 0x4F, 0x50);
            sceneRenderer.DrawLine(new Point(144, 326.668), new Point(147.334, 338.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(8.667, 356.001), new Point(12.334, 360.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(11.334, 360.001), new Point(29.334, 358.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(29, 357.668), new Point(32.667, 356.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(32, 355.668), new Point(26.667, 354.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(28, 355.335), new Point(9, 356.335), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x54, 0x53);
            sceneRenderer.DrawLine(new Point(12.334, 358.335), new Point(24, 358.335), brush, 3f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(58, 329.335);
                ellipse.RadiusX = 11f;
                ellipse.RadiusY = 6.667f;
                brush.Color = Color.FromArgb(0xFF, 0x38, 0x3C, 0x3D);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(82.834, 325.835);
                ellipse.RadiusX = 10.167f;
                ellipse.RadiusY = 6.5f;
                brush.Color = Color.FromArgb(0xFF, 0x38, 0x3C, 0x3D);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(38.334, 332.668), new Point(15.334, 337.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(19, 336.668), new Point(-1.666, 334.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(27.667, 330.335), new Point(8, 335.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(113, 312.668), new Point(133.334, 321.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(126.334, 313.668), new Point(141.667, 320.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(102, 326.668), new Point(121, 323.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x7D, 0x6A);
            sceneRenderer.DrawLine(new Point(126, 323.001), new Point(107, 322.668), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(53.667, 340.668), new Point(20, 341.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(22, 343.001), new Point(-11, 348.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(93.334, 336.668), new Point(114, 329.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(111.667, 330.335), new Point(144.334, 325.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(92.334, 351.001), new Point(112.334, 347.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(108.334, 346.668), new Point(127, 344.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(135.667, 342.001), new Point(127, 347.001), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0xDC, 0xE3, 0xE5);
            sceneRenderer.DrawLine(new Point(122.334, 346.335), new Point(132.667, 342.668), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(233, 316.335), new Point(146.334, 313.668), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(185.667, 299.001), new Point(140.667, 289.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(160, 291.001), new Point(159, 284.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(161, 287.001), new Point(134.334, 284.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(130, 279.668), new Point(129.667, 300.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(128.667, 286.668), new Point(118.667, 292.335), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(114.334, 289.001), new Point(137, 306.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(138.334, 288.668), new Point(138.334, 326.001), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(135.667, 285.668), new Point(126, 316.335), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(150.667, 338.668), new Point(159.334, 345.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(157.667, 342.668), new Point(163.667, 346.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(162, 346.001), new Point(177.334, 343.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(176.334, 344.001), new Point(182.667, 346.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(179.667, 347.001), new Point(196.334, 348.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(193.667, 348.335), new Point(204.334, 348.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(202.667, 348.001), new Point(213.334, 351.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(229, 345.335), new Point(210.667, 353.335), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0xE1, 0xE1);
            sceneRenderer.DrawLine(new Point(228, 342.668), new Point(147.334, 336.668), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(150, 342.332), new Point(157, 355.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(156.334, 352.665), new Point(172.334, 359.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(170.334, 359.332), new Point(168, 371.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(151.667, 373.665), new Point(177.667, 381.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(174.667, 380.999), new Point(205, 375.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(140.667, 337.332), new Point(208.334, 359.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xD1, 0xD1, 0xD0);
            sceneRenderer.DrawLine(new Point(170, 363.665), new Point(207, 375.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(159.334, 355.665), new Point(163.667, 371.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(158.667, 372.999), new Point(87.667, 400.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(118, 389.332), new Point(210, 389.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(209.334, 398.999), new Point(99, 401.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(118, 388.999), new Point(44.334, 401.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(46, 394.999), new Point(34.667, 401.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(33.334, 400.665), new Point(36.667, 408.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(37, 403.665), new Point(48, 403.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(42, 395.999), new Point(45.334, 412.332), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(47, 410.332), new Point(80.334, 406.665), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(91, 403.332), new Point(72.667, 404.665), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(70.334, 424.999), new Point(82.334, 403.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(74.667, 422.332), new Point(122.667, 408.999), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(76, 417.332), new Point(111, 399.665), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(112.667, 421.665), new Point(127, 407.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(123, 414.999), new Point(134, 411.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(123.334, 408.999), new Point(143.667, 412.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(140.334, 414.332), new Point(151, 407.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(137, 407.999), new Point(171, 411.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(162.667, 408.999), new Point(190.334, 407.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB5, 0xB5, 0xB6);
            sceneRenderer.DrawLine(new Point(185, 408.999), new Point(206, 407.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(149.667, 354.665), new Point(152.334, 368.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(150.334, 363.999), new Point(144, 372.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(146.667, 368.332), new Point(116.334, 378.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(116, 378.999), new Point(79.334, 385.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(79.334, 385.665), new Point(32, 394.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(41.667, 393.999), new Point(19.667, 394.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(34.667, 398.332), new Point(22.667, 402.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(207.667, 425.332), new Point(189, 437.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(190, 435.998), new Point(176, 440.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(175, 442.665), new Point(173.334, 449.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(174.334, 449.998), new Point(179.667, 449.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(182.667, 450.332), new Point(170.334, 451.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(170.334, 447.665), new Point(163, 448.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(163, 446.665), new Point(156.334, 452.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(156.334, 444.332), new Point(143, 454.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(147.334, 446.332), new Point(134.667, 447.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(137.334, 445.332), new Point(127, 443.998), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(128, 439.332), new Point(118.334, 448.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(120.667, 443.998), new Point(108, 434.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(110.667, 435.998), new Point(94.667, 425.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(97.334, 425.999), new Point(66.334, 424.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(70.334, 423.665), new Point(60.667, 417.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(34.667, 403.332), new Point(61.667, 421.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(206, 402.999), new Point(204.334, 425.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(88.334, 418.999), new Point(201.667, 417.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(54, 406.999), new Point(75.667, 417.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(199, 426.999), new Point(103.667, 427.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x9F, 0x9E);
            sceneRenderer.DrawLine(new Point(181.667, 440.332), new Point(116.334, 438.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(57.334, 418.664), new Point(70.334, 430.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(65.667, 427.997), new Point(72, 431.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(69.334, 431.331), new Point(90.667, 431.664), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(95.334, 428.331), new Point(84.667, 443.664), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(84, 439.33), new Point(104, 453.997), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(101.667, 449.997), new Point(107, 464.33), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(91.334, 432.997), new Point(159.334, 481.997), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(100.667, 504.663), new Point(171.334, 565.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(132, 519.996), new Point(186, 573.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(6, 420.663), new Point(6, 429.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(6.334, 426.996), new Point(14.667, 439.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(11, 431.33), new Point(45, 449.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(21, 440.996), new Point(37, 463.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(26, 453.996), new Point(7.667, 456.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(7, 460.663), new Point(30, 462.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(9, 468.329), new Point(24, 468.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(24.667, 467.329), new Point(41.334, 467.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(34, 476.329), new Point(134.334, 480.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(45, 484.663), new Point(69.334, 477.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(118, 466.329), new Point(101.334, 466.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(104.667, 467.663), new Point(83.667, 474.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(97.667, 474.329), new Point(130.667, 473.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(68.667, 433.329), new Point(50, 442.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(42.667, 450.329), new Point(92.334, 434.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(31.667, 448.996), new Point(48.667, 461.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(39.334, 466.663), new Point(86.667, 470.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(37, 460.329), new Point(102.334, 463.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(46.667, 451.663), new Point(102, 453.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(64, 446.663), new Point(92, 448.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(103.334, 450.996), new Point(145.667, 484.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(110.667, 501.329), new Point(150, 477.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(132.334, 481.663), new Point(110, 494.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(141, 483.663), new Point(175, 480.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(205, 426.663), new Point(205.334, 448.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(205, 442.663), new Point(221, 459.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(215.334, 456.329), new Point(222, 465.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(220.334, 462.329), new Point(218, 475.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(217.334, 475.996), new Point(208, 478.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(207.667, 479.329), new Point(209.667, 488.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(203.334, 481.663), new Point(201, 487.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(196.334, 478.329), new Point(193.667, 484.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(190.667, 481.329), new Point(184.334, 493.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(185.667, 483.329), new Point(167.667, 483.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(168, 483.329), new Point(177.334, 489.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(120.667, 442.996), new Point(168.667, 478.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(137, 446.663), new Point(183, 480.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(153.667, 450.329), new Point(194, 481.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(162.334, 447.996), new Point(208.667, 481.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(176.667, 449.996), new Point(213, 474.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(178, 440.329), new Point(216.667, 466.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(188.334, 436.329), new Point(214.667, 455.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(195.334, 432.996), new Point(202.334, 440.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(102.667, 497.996), new Point(116.334, 511.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(115.334, 505.996), new Point(132.667, 521.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(118.334, 502.996), new Point(169.334, 509.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(147, 504.329), new Point(176, 504.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(165.334, 508.663), new Point(186.334, 514.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(173, 504.663), new Point(209.334, 520.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(195.667, 509.663), new Point(227.667, 533.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(222.667, 531.996), new Point(243.334, 541.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(193.334, 518.996), new Point(204, 553.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(202.334, 520.663), new Point(215.667, 557.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(208.667, 525.996), new Point(225.667, 550.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(221.334, 535.996), new Point(233.667, 550.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(78, 497.663), new Point(91.667, 506.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(86.334, 500.663), new Point(93.667, 500.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(89.334, 507.329), new Point(103.667, 514.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(93.334, 498.996), new Point(99, 507.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(104, 515.663), new Point(114.667, 530.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(114.667, 527.663), new Point(139.334, 549.329), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(137, 546.329), new Point(163, 576.663), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8C, 0x87, 0x85);
            sceneRenderer.DrawLine(new Point(101.334, 518.329), new Point(119.334, 500.996), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x73, 0x72);
            sceneRenderer.DrawLine(new Point(176, 486.334), new Point(201.333, 506), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x73, 0x72);
            sceneRenderer.DrawLine(new Point(190.667, 485), new Point(234, 533.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x73, 0x72);
            sceneRenderer.DrawLine(new Point(201.667, 483), new Point(242, 530), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x73, 0x72);
            sceneRenderer.DrawLine(new Point(209.333, 475.334), new Point(242.667, 523.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x73, 0x72);
            sceneRenderer.DrawLine(new Point(218, 466), new Point(233, 505.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(147.75, 229), new Point(137.75, 241.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(137, 225), new Point(131.5, 242.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(140.75, 240.25), new Point(136.5, 244), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(129, 239.5), new Point(128, 250.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(133, 244.25), new Point(125.25, 257.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(121, 247.5), new Point(119, 264.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(116.75, 256.5), new Point(111.5, 264.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(112, 261.5), new Point(112.5, 272.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(113, 271), new Point(120.25, 264), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(118, 262.75), new Point(115, 267), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(122.75, 258.5), new Point(138.5, 264.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(129.75, 255), new Point(139.75, 277), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(133.75, 267.5), new Point(135, 277), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(134.5, 277), new Point(149.5, 270.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(136, 268.5), new Point(145.25, 272), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(147.5, 270.25), new Point(155, 271.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x60, 0x68, 0x6E);
            sceneRenderer.DrawLine(new Point(153.75, 270.75), new Point(154, 277.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC2, 0x69, 0x7A);
            sceneRenderer.DrawLine(new Point(114.5, 259.25), new Point(106.5, 263.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC2, 0x69, 0x7A);
            sceneRenderer.DrawLine(new Point(108.5, 261.5), new Point(90.75, 264.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC2, 0x69, 0x7A);
            sceneRenderer.DrawLine(new Point(102.75, 263.5), new Point(97.75, 270.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC2, 0x69, 0x7A);
            sceneRenderer.DrawLine(new Point(99.75, 268.5), new Point(106.5, 271), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC2, 0x69, 0x7A);
            sceneRenderer.DrawLine(new Point(106.75, 270), new Point(104.75, 275.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xD5, 0xBF, 0xCC);
            sceneRenderer.DrawLine(new Point(89, 262.25), new Point(106.25, 257.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xD5, 0xBF, 0xCC);
            sceneRenderer.DrawLine(new Point(103.25, 257.75), new Point(116, 256.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(134.5, 272.5), new Point(114.25, 274.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(114.5, 274.5), new Point(105, 274.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(104.5, 263.25), new Point(111.75, 273.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(133, 263.75), new Point(111.5, 271.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(171.75, 231.25), new Point(166.75, 237.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(167.75, 235.75), new Point(169, 250), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(173.5, 247.5), new Point(172.5, 251.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(174, 250.5), new Point(160, 255), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(162.25, 255.25), new Point(163.75, 260.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(164.75, 258.25), new Point(173.75, 260.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(162.5, 260.75), new Point(155, 254.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(156, 255.75), new Point(149.5, 263.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(149.25, 261.75), new Point(148.75, 268.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(169.5, 232.5), new Point(150, 232.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(159.5, 232.5), new Point(161, 254.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(152.5, 233), new Point(142.5, 272.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xEB, 0xEC, 0xE9);
            sceneRenderer.DrawLine(new Point(139.75, 239.75), new Point(134.25, 263.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(180.5, 246), new Point(183.25, 260.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(172.5, 247), new Point(169.75, 261.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(161.25, 251.25), new Point(161.5, 263.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(168, 246.75), new Point(184.25, 247.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(186.75, 249.75), new Point(191.75, 256), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(162.75, 261.5), new Point(164, 267.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCE, 0xC8, 0xC7);
            sceneRenderer.DrawLine(new Point(166.25, 262), new Point(171, 262.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(192.75, 237), new Point(190.75, 246.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(189.25, 245), new Point(194.5, 253), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(193, 253), new Point(209.25, 254.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(205.75, 255), new Point(215.25, 251.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(214, 251.5), new Point(223, 251), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(227, 249.75), new Point(222.25, 250.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(223.75, 248.75), new Point(212.25, 246.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(213.75, 246), new Point(211, 238.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(214, 236.75), new Point(192.75, 238.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(192.25, 242.75), new Point(211.75, 241.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(191.75, 246.75), new Point(212, 245.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF4, 0xF2, 0xF3);
            sceneRenderer.DrawLine(new Point(194, 250.75), new Point(215.75, 248.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x91, 0x91);
            sceneRenderer.DrawLine(new Point(208.5, 256.75), new Point(200, 263.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x91, 0x91);
            sceneRenderer.DrawLine(new Point(203.25, 261.75), new Point(191.25, 266), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x91, 0x91);
            sceneRenderer.DrawLine(new Point(194.5, 264.5), new Point(183.5, 266), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x91, 0x91);
            sceneRenderer.DrawLine(new Point(175.25, 262), new Point(187.25, 268), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x91, 0x91);
            sceneRenderer.DrawLine(new Point(179.25, 262.5), new Point(204.75, 255.5), brush, 10f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(207.75, 274.75);
                ellipse.RadiusX = 3.5f;
                ellipse.RadiusY = 7.75f;
                brush.Color = Color.FromArgb(0xFF, 0xCD, 0xD0, 0xD3);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x3A, 0x36);
            sceneRenderer.DrawLine(new Point(173.5, 269.5), new Point(163.25, 271), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x3A, 0x36);
            sceneRenderer.DrawLine(new Point(175, 272.5), new Point(163.75, 274.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x3A, 0x36);
            sceneRenderer.DrawLine(new Point(164.75, 269.5), new Point(162.5, 277.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x3A, 0x36);
            sceneRenderer.DrawLine(new Point(163, 276.25), new Point(165.25, 279.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x38, 0x3A, 0x36);
            sceneRenderer.DrawLine(new Point(175.25, 279.25), new Point(163.25, 279.25), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(176, 272), new Point(175.75, 265.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(174, 264.75), new Point(183.25, 265), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(180.75, 265.25), new Point(183.25, 270.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(182.5, 270), new Point(182.5, 275.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(182, 273.25), new Point(188.75, 275.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(185.75, 275.75), new Point(198.25, 274), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(196.5, 274), new Point(206.25, 277), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(230.25, 254.5), new Point(220, 256.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(222.25, 256), new Point(213.5, 261.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(211.5, 265), new Point(221.25, 265.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(229.25, 259.75), new Point(219.75, 266.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(231.75, 259.25), new Point(224.5, 265.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(228.75, 251), new Point(208.25, 258.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(216.75, 257.5), new Point(193.25, 269.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(182.25, 269.5), new Point(194.5, 268.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(183.5, 271.75), new Point(205.75, 272.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(198.5, 270.25), new Point(215.5, 263.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x5F, 0x60);
            sceneRenderer.DrawLine(new Point(218, 264.5), new Point(207.75, 270.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(182.5, 279), new Point(211.5, 279.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(208, 275.5), new Point(226.75, 266), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(234, 268.25), new Point(219.75, 268.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(243.25, 257), new Point(229, 269), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(230.25, 248), new Point(236, 258), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(236.5, 248), new Point(244.5, 254.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(249.5, 250.25), new Point(238.25, 245.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(226, 249.25), new Point(239.75, 247.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(242.75, 256.5), new Point(246.5, 262.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(241.75, 260.5), new Point(245, 266.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(246.75, 262.25), new Point(243.25, 269.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(235.25, 278.5), new Point(239.75, 279.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x44, 0x42);
            sceneRenderer.DrawLine(new Point(227.75, 283.5), new Point(238.75, 283.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(255.5, 191.5), new Point(262.25, 196), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(260.5, 193.75), new Point(265.5, 201), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(263.75, 198), new Point(267.5, 207.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(266.75, 205), new Point(269, 213.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(268.75, 212.5), new Point(268.75, 222.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(268.75, 221.75), new Point(266.5, 230.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(226.25, 203.25), new Point(230.75, 197.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(229.5, 198.75), new Point(237.25, 196.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(236.25, 196.75), new Point(245.25, 196.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(242.75, 197.25), new Point(255, 197.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(255.5, 192.5), new Point(253, 198.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(232.5, 207.25), new Point(235.25, 218.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(233.75, 215.25), new Point(236.25, 227), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(235.75, 224), new Point(236.5, 233.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(238.75, 235), new Point(231, 232.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(231.75, 232.5), new Point(230, 229.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(229.75, 229.5), new Point(227.75, 205), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(228.75, 201.25), new Point(234.25, 231.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(248.75, 204.25), new Point(248.75, 216), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(249, 215.25), new Point(252, 233.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(249, 233), new Point(255.5, 237), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(253.5, 236.25), new Point(257.25, 240.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(255.25, 240), new Point(267.5, 228.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(234.75, 208.5), new Point(245.75, 203.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(243.5, 205), new Point(250.25, 206.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(230, 204.75), new Point(245, 200.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(242.5, 199.75), new Point(263.25, 203), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(255, 195), new Point(264.5, 205), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(254.25, 203.25), new Point(255.25, 236.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(259.25, 205.75), new Point(260, 233.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(263.75, 204), new Point(264.25, 232), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(216.75, 166.5), new Point(219.25, 187.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(222.25, 169.75), new Point(226.5, 197), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(221.5, 186.5), new Point(222, 196.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(229.75, 176.5), new Point(233.25, 194.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(236.25, 181.5), new Point(239.75, 192.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(241, 179.5), new Point(246.5, 189), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(284.5, 203.25), new Point(282, 217.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(288, 206.25), new Point(286, 215), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(279.25, 205.25), new Point(277.75, 212), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xF0, 0xEC, 0xE6);
            sceneRenderer.DrawLine(new Point(288, 202.25), new Point(289.25, 209), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1092.75, 309.5), new Point(1090.75, 314.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1090.75, 312), new Point(1096.25, 311), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1082.5, 313.5), new Point(1082, 320), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1082.5, 317), new Point(1087, 314.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1076.75, 321.75), new Point(1077.75, 327.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1078.5, 321.25), new Point(1080.25, 330.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1074.75, 331.5), new Point(1078.25, 337.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1076, 333.25), new Point(1084.5, 336.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1079, 340.25), new Point(1085.75, 345.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1081.5, 341.75), new Point(1088, 342.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1082, 348), new Point(1091, 351), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1084.5, 349), new Point(1095.75, 343.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1090.5, 345), new Point(1097, 347), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1086.75, 349), new Point(1103.25, 348.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1088, 350.75), new Point(1099.5, 350.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1093.5, 344.25), new Point(1101.5, 345.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1096, 346.5), new Point(1108, 346.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1105.25, 338.5), new Point(1101.5, 344), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1106.5, 337), new Point(1104.25, 344.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1109, 328.25), new Point(1106, 342), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1105.5, 316.25), new Point(1113, 325.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1099, 314), new Point(1106, 308.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1102.75, 307.5), new Point(1114.75, 316.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1101.25, 313.5), new Point(1111.5, 313.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1101.5, 311.75), new Point(1108.25, 311.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1108, 313.25), new Point(1115.5, 327), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1111.5, 313.75), new Point(1116.5, 327), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1113.75, 316.75), new Point(1117.75, 324.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1112.75, 324), new Point(1107.25, 346.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1109.5, 320.5), new Point(1110.5, 330), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1115, 325.75), new Point(1110.25, 344.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1117.25, 324.25), new Point(1113.5, 341.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1117.5, 328.5), new Point(1114.5, 338.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1114.25, 339.25), new Point(1108.25, 346.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1097, 350.75), new Point(1110.75, 345.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x5B, 0x5F, 0x6F);
            sceneRenderer.DrawLine(new Point(1108.75, 342.75), new Point(1097.5, 347), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(259, 294), new Point(388, 274), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(406, 284), new Point(619, 263), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(276, 270), new Point(415, 265), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(605, 242), new Point(650, 343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(284, 251), new Point(387, 251), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(632, 303), new Point(422, 340), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x47, 0x44);
            sceneRenderer.DrawLine(new Point(255.5, 256), new Point(245.5, 310.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x47, 0x44);
            sceneRenderer.DrawLine(new Point(242, 283), new Point(240, 312.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x47, 0x44);
            sceneRenderer.DrawLine(new Point(252.5, 268), new Point(249, 323), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(241, 305.5), new Point(231.5, 340), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(247.5, 308.5), new Point(236, 355), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(259.5, 254.5), new Point(258, 327), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(274.5, 242), new Point(262.5, 280), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(294, 229.5), new Point(274.5, 250.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(294.5, 233), new Point(344.5, 225), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(333.5, 229.5), new Point(373, 235), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(256, 324), new Point(252, 348.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x48, 0x44);
            sceneRenderer.DrawLine(new Point(236, 333), new Point(239.5, 365.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x48, 0x44);
            sceneRenderer.DrawLine(new Point(283.5, 228.5), new Point(252.5, 260), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x48, 0x44);
            sceneRenderer.DrawLine(new Point(272, 243.5), new Point(251.5, 274.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x48, 0x44);
            sceneRenderer.DrawLine(new Point(349, 222), new Point(303.5, 220), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x48, 0x44);
            sceneRenderer.DrawLine(new Point(306.5, 217), new Point(279, 232.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(314.5, 213.5), new Point(511.5, 198), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(505.5, 199), new Point(547.5, 204.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(548, 204.5), new Point(574, 210.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(574.5, 210.5), new Point(602.5, 226.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(604, 226.5), new Point(478, 234.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(478, 234), new Point(466, 234), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(465.5, 234), new Point(465.5, 228.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(465.5, 228.5), new Point(472.5, 214), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(472.5, 213.5), new Point(464.5, 210), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(467.5, 205.5), new Point(371.5, 214), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(372, 214.5), new Point(352, 210.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(351.5, 210.5), new Point(334, 211), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(470, 219.5), new Point(587.5, 223), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7D, 0x7D, 0x7C);
            sceneRenderer.DrawLine(new Point(560.5, 210.5), new Point(468, 210.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(466.5, 210), new Point(372, 219.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(345, 216), new Point(375.5, 220.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(349, 217.5), new Point(382.5, 227), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(374.5, 229), new Point(450.5, 221), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(459, 212.5), new Point(439, 245), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(392.5, 240), new Point(472.5, 234), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(402.5, 250), new Point(615.5, 233), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(605, 221.5), new Point(605.5, 232), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(606.5, 226.5), new Point(613.5, 229.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(485, 241.5), new Point(461.5, 235.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(467.5, 210.5), new Point(451, 219.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(318, 213), new Point(302.5, 214.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(655.5, 317.5), new Point(433, 354), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(654, 326.5), new Point(435, 363.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(259, 311), new Point(397, 283), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(776, 604), new Point(841, 591), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(869.5, 559.5), new Point(844.5, 559.5), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xEB, 0xEC);
            sceneRenderer.DrawLine(new Point(851, 580.5), new Point(829, 590), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(906, 518.5), new Point(911, 610.5), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x3A, 0x35);
            sceneRenderer.DrawLine(new Point(533.333, 733.333), new Point(747.333, 731.333), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x3A, 0x35);
            sceneRenderer.DrawLine(new Point(535.333, 732), new Point(348, 607.333), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x3A, 0x35);
            sceneRenderer.DrawLine(new Point(360.667, 619.333), new Point(256.667, 532.667), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x3A, 0x35);
            sceneRenderer.DrawLine(new Point(731.333, 718.667), new Point(840.667, 685.333), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x3F, 0x3A, 0x35);
            sceneRenderer.DrawLine(new Point(817.333, 677.333), new Point(901.333, 643.333), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(762, 604.75), new Point(764.5, 678.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(748.75, 617.75), new Point(752.75, 678.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(732.5, 635.25), new Point(738, 665.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(728.25, 647), new Point(659.25, 669.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(617, 661), new Point(662, 670.75), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(520.75, 511), new Point(551, 545.5), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(480, 500.75), new Point(504.75, 496.5), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(570.75, 588.75), new Point(591.75, 633.5), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(585, 625.5), new Point(621.75, 668.75), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(643, 691), new Point(689, 692.333), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(733, 677.333), new Point(663.667, 696.667), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9E, 0xA0);
            sceneRenderer.DrawLine(new Point(649.667, 708.667), new Point(689, 708.667), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(826, 796), new Point(971, 878), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(837, 720), new Point(978, 798), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(728, 759), new Point(809, 796), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(578, 767), new Point(669, 816), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x93, 0x91, 0x8F);
            sceneRenderer.DrawLine(new Point(651.5, 321), new Point(889, 331.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x93, 0x91, 0x8F);
            sceneRenderer.DrawLine(new Point(920.5, 331), new Point(1081, 362.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x93, 0x91, 0x8F);
            sceneRenderer.DrawLine(new Point(1082.5, 361), new Point(1167.5, 366), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x93, 0x91, 0x8F);
            sceneRenderer.DrawLine(new Point(1157.5, 369.5), new Point(1065, 360), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x93, 0x91, 0x8F);
            sceneRenderer.DrawLine(new Point(882.5, 332.5), new Point(1044.5, 362.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(1155.5, 401.5), new Point(830, 370), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(887.5, 350.5), new Point(644, 342.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(743, 368), new Point(844.5, 379), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(876.5, 342), new Point(915, 346.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(919.5, 346.5), new Point(966, 353), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAC, 0xA9, 0xA8);
            sceneRenderer.DrawLine(new Point(964, 350.5), new Point(1107, 368), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(926.5, 477.5), new Point(1200, 524), brush, 180f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(1107.5, 413.5), new Point(1160.5, 421.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(1104.5, 409), new Point(990, 398), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(1153, 414), new Point(1130, 416), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(1128, 408.5), new Point(1101.5, 410), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(997, 392), new Point(958, 391.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(999, 397.5), new Point(933.5, 382.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(937, 379.5), new Point(908, 389), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(898, 379), new Point(913.5, 393.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(907.5, 390.5), new Point(895, 390.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(893.5, 392), new Point(879, 375), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(894.5, 383), new Point(852, 383), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(857.5, 383.5), new Point(842, 393.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(849, 391.5), new Point(817.5, 386.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(819.5, 386.5), new Point(821, 395.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(817.5, 398), new Point(802, 394), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(819.5, 389.5), new Point(799.5, 389.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(781.5, 381), new Point(802.5, 398), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(788, 383), new Point(808, 391), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(903, 387.5), new Point(923.5, 529), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xB6, 0xB4, 0xB4);
            sceneRenderer.DrawLine(new Point(913, 423), new Point(805, 431.5), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(909.667, 546.336), new Point(996, 585.003), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1155.667, 621.003), new Point(988, 582.669), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1018.334, 564.336), new Point(1056, 579.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(918, 521.336), new Point(932.334, 537.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(945.334, 532.003), new Point(934.334, 535.669), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(954.667, 536.003), new Point(954.667, 543.669), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(955.667, 535.669), new Point(965.334, 550.336), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(982.667, 553.336), new Point(988, 559.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(989.667, 556.003), new Point(998.667, 565.336), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1000, 555.336), new Point(995, 562.669), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1011.667, 559.003), new Point(1022, 567.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(955, 548.336), new Point(950.334, 539.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1064.334, 573.669), new Point(1070.667, 579.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1067.667, 567.669), new Point(1070.667, 574.336), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1075.334, 574.336), new Point(1086.667, 591.669), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1103, 575.669), new Point(1081.667, 585.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1086.667, 583.669), new Point(1111.334, 587.336), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1109, 580.669), new Point(1113, 584.336), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1110.667, 586.336), new Point(1125, 592.669), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1126.667, 589.003), new Point(1134.334, 596.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1130.667, 581.669), new Point(1144.334, 601.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1154, 586.003), new Point(1150.667, 601.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xAE, 0xAB, 0xA8);
            sceneRenderer.DrawLine(new Point(1125.334, 593.003), new Point(1148.334, 593.003), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(909.334, 603.668), new Point(1165.667, 672.335), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(943.334, 575.669), new Point(1030.334, 603.669), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1091, 618.336), new Point(1160.334, 634.336), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1088.334, 606.336), new Point(1073.667, 605.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1074.667, 605.669), new Point(1063.334, 605.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1068.334, 604.669), new Point(1056.667, 598.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1060.334, 597.003), new Point(1043.667, 597.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1047, 597.669), new Point(1029.334, 580.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1091, 607.669), new Point(1099.667, 610.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1099, 611.669), new Point(1121.667, 618.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1121.334, 618.336), new Point(1134.667, 618.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1129.667, 618.336), new Point(1160.334, 631.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1042.667, 594.003), new Point(1030.334, 602.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1034, 594.003), new Point(1012.334, 594.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1019.334, 589.669), new Point(1006.667, 585.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1007.334, 576.336), new Point(1002.667, 579.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(1007, 582.336), new Point(975.667, 582.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(985.667, 582.003), new Point(972, 570.336), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(974.334, 574.336), new Point(966, 579.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(971, 577.336), new Point(949.667, 570.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(931.334, 563.669), new Point(939.667, 566.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(942.334, 567.003), new Point(952.334, 562.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(948.334, 564.669), new Point(946, 574.003), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(948, 575.669), new Point(932.667, 576.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x9F, 0x9C, 0x9A);
            sceneRenderer.DrawLine(new Point(940.667, 577.669), new Point(915.334, 577.669), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(982.334, 685.006), new Point(1154, 710.006), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(891.667, 626.006), new Point(985.334, 668.34), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(988, 646.673), new Point(1010.667, 648.673), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(907.667, 608.34), new Point(922.334, 616.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(922.334, 616.673), new Point(922.334, 605.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(937, 611.673), new Point(923.334, 611.673), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(886.667, 612.006), new Point(907.334, 614.006), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(959, 637.673), new Point(978.334, 636.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(973.667, 634.673), new Point(981.334, 646.673), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(988, 653.006), new Point(1044, 666.006), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1027.667, 659.673), new Point(1055, 656.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1040, 646.006), new Point(1047.667, 648.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1047.334, 643.006), new Point(1056.334, 661.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1038.667, 661.006), new Point(1118.334, 670.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1095, 663.34), new Point(1070.334, 657.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1074.667, 656.006), new Point(1058.334, 656.006), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1115.667, 670.006), new Point(1151, 675.34), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(1152, 675.34), new Point(1119.667, 665.006), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(995, 639.006), new Point(1017.334, 649.673), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(881.667, 632.336), new Point(892, 647.67), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(985.667, 635.335), new Point(985.334, 642.668), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x94, 0x92, 0x8F);
            sceneRenderer.DrawLine(new Point(933, 625.668), new Point(967, 635.002), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(901.667, 693.676), new Point(1143, 785.677), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1083.667, 725.342), new Point(1164.667, 737.009), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1008.667, 687.342), new Point(1038.667, 701.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(998, 682.342), new Point(950, 673.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(966.334, 663.009), new Point(981.667, 676.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(987.334, 671.009), new Point(975.667, 675.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(956.667, 670.676), new Point(941.667, 655.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(941.334, 644.342), new Point(925.667, 663.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(946, 668.009), new Point(920.334, 641.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1049.667, 707.009), new Point(1086, 717.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1098.334, 706.009), new Point(1109, 718.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1103.667, 715.009), new Point(1124, 720.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1120.334, 719.342), new Point(1160.667, 722.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(1156.667, 707.342), new Point(1146, 719.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(922.334, 660.009), new Point(884.334, 641.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(876.667, 622.009), new Point(893, 643.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(880.334, 617.342), new Point(918, 635.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(915.334, 637.342), new Point(926.334, 641.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(884.667, 622.342), new Point(929.334, 656.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(887, 631.342), new Point(920.667, 658.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(879.667, 647.009), new Point(959.667, 672.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(890.667, 652.676), new Point(886.334, 669.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x86, 0x83);
            sceneRenderer.DrawLine(new Point(944.334, 642.342), new Point(945.334, 648.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(933.667, 728.342), new Point(1045.667, 770.009), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(966, 793.342), new Point(1154, 852.342), brush, 100f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(883.667, 668.009), new Point(925, 707.342), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1082.667, 745.342), new Point(1095.334, 782.009), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1101, 782.009), new Point(1138.334, 787.342), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(967, 701.676), new Point(929, 707.342), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1147, 772.342), new Point(1150.667, 805.009), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(988.667, 687.342), new Point(973.334, 697.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(981.334, 690.009), new Point(965, 694.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(933.667, 691.342), new Point(956.667, 692.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(892.667, 649.009), new Point(916, 663.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(921.667, 653.342), new Point(921, 664.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(954, 712.342), new Point(986.334, 721.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1003, 717.009), new Point(1055.334, 753.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1034.334, 725.676), new Point(1055.667, 745.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1028.667, 741.009), new Point(997, 729.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(990, 704.009), new Point(1017, 709.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1017.667, 704.676), new Point(993.667, 713.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1048.334, 762.676), new Point(1088.334, 777.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1082.667, 761.342), new Point(1047, 761.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1088.667, 743.676), new Point(1107, 765.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1104, 741.342), new Point(1117, 761.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1111.667, 764.676), new Point(1104, 772.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1130.667, 732.676), new Point(1141.334, 741.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1144, 747.009), new Point(1156, 750.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1155.667, 749.342), new Point(1138, 759.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1145.667, 758.342), new Point(1148.667, 766.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1151.334, 753.342), new Point(1154, 775.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(1134.667, 740.676), new Point(1157, 750.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(882, 647.676), new Point(843, 711.342), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(889.334, 664.342), new Point(858, 705.676), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(868.334, 691.342), new Point(911, 720.009), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(860, 706.342), new Point(906, 705.342), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(904.334, 715.009), new Point(926, 703.676), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(921, 703.342), new Point(933, 734.009), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(903.334, 716.342), new Point(938.667, 726.009), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(930.334, 720.676), new Point(954.334, 720.676), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(903, 786.342), new Point(1019.334, 844.342), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1042.667, 849.009), new Point(1166.334, 868.676), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(961, 758.009), new Point(976.667, 801.676), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(995.667, 776.342), new Point(1021.334, 795.009), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(998, 787.009), new Point(987.334, 789.676), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(973.667, 777.676), new Point(990.334, 783.342), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1106.667, 820.676), new Point(1140.334, 845.009), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1157, 838.676), new Point(1137, 850.676), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1017.334, 835.342), new Point(1041.334, 864.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(995.334, 803.676), new Point(1002, 812.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1007.667, 813.009), new Point(1015, 818.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1003.334, 797.676), new Point(1021.667, 810.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1020.667, 793.342), new Point(1025.667, 801.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1036.334, 817.009), new Point(1041.667, 826.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1040.334, 826.342), new Point(1037, 839.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1037, 839.342), new Point(1046.334, 855.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1042.667, 817.009), new Point(1044.667, 840.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1077.667, 827.676), new Point(1093.334, 837.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1135.334, 807.342), new Point(1131.667, 813.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(1124.334, 808.676), new Point(1129.334, 827.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(956.667, 719.009), new Point(942.667, 738.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x70, 0x6B, 0x67);
            sceneRenderer.DrawLine(new Point(942.334, 727.009), new Point(957.667, 733.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(876.334, 626.342), new Point(877.667, 646.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(875.334, 637.009), new Point(861, 652.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(861.667, 652.009), new Point(851.667, 674.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(851.334, 674.676), new Point(837.667, 690.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(836.667, 690.342), new Point(836.667, 703.009), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(842.334, 691.009), new Point(849.334, 697.342), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(835.334, 702.009), new Point(838, 714.676), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(800.5, 845), new Point(897.5, 876.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(692.5, 780.5), new Point(600.5, 776.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(593, 761), new Point(604.5, 764), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(563.5, 752.5), new Point(581.5, 758.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(580, 759), new Point(595, 767.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(592, 756), new Point(607, 758.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(608, 762.5), new Point(621.5, 761.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(613, 754), new Point(627, 763.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(640.5, 762), new Point(649.5, 762), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(659.5, 764.5), new Point(664, 766), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(705, 755), new Point(704.5, 784), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(702.5, 769.5), new Point(694, 779), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(694.5, 762), new Point(688, 767), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(716, 759.5), new Point(746.5, 779.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(705, 762.5), new Point(724, 783.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(710.5, 767), new Point(743, 785), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(728, 752.5), new Point(756, 773.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(740.5, 748.5), new Point(759, 765), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(765.5, 771), new Point(864.5, 765.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(872.5, 828.5), new Point(795.5, 822.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(796.5, 804), new Point(902, 781.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(758, 739.5), new Point(853.5, 747.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(823, 715.5), new Point(866, 730.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(853.5, 714), new Point(871.5, 721), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(778, 724.5), new Point(854.5, 743.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(860.5, 764.5), new Point(893, 773), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(883.5, 795.5), new Point(909, 799.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(961.5, 851), new Point(1021.5, 856.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(889, 723.5), new Point(936, 753.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(901.5, 751), new Point(961.5, 777.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(967.5, 755.5), new Point(922, 756), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(928, 777), new Point(964, 788), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(886, 733.5), new Point(910, 755), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(896, 766), new Point(922, 779.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(850, 703), new Point(857.5, 717.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(881, 711), new Point(867.5, 728), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(884, 702), new Point(891.5, 708.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(888, 707), new Point(889.5, 721), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(891.5, 717), new Point(908, 721), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(911, 727), new Point(936, 740.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(897, 806), new Point(918, 817.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(909, 800.5), new Point(916, 827.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(900, 781.5), new Point(913, 789.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(919, 822), new Point(955.5, 832.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(942.5, 832), new Point(954.5, 842), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(963.5, 845.5), new Point(952, 845.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(949.5, 820.5), new Point(944.5, 821.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(945, 809.5), new Point(945, 815.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(954.5, 810), new Point(951, 816.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(966.5, 838), new Point(991, 847), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(994, 841.5), new Point(1023, 846), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(1019, 856), new Point(1031.5, 863), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(877, 838), new Point(835.5, 848), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(877, 820.5), new Point(869, 820.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(867.5, 804), new Point(845.5, 812.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x63, 0x5E, 0x57);
            sceneRenderer.DrawLine(new Point(968, 750.5), new Point(968, 758.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(659, 787), new Point(676.5, 789.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(675, 776.5), new Point(683, 790.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(681.5, 782.5), new Point(697, 784), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(697, 784.5), new Point(704, 787.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(704, 787.5), new Point(709.5, 777), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(706, 780.5), new Point(722.5, 790), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(722.5, 790.5), new Point(728.5, 792), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(721, 777), new Point(727.5, 784), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(725.5, 787), new Point(746.5, 787), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(678, 784.5), new Point(670.5, 786), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(652.5, 790), new Point(668.5, 796), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(752, 780.5), new Point(744.5, 783), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(750, 782), new Point(751.5, 768), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(753.5, 778), new Point(767, 762), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(764, 756.5), new Point(757, 759), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(764, 761), new Point(780, 786), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(760.5, 771), new Point(770, 774.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(773.5, 755), new Point(779.5, 760.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(769.5, 760.5), new Point(782, 779.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(779, 777.5), new Point(780.5, 761), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(752.5, 780), new Point(771, 788), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(767, 783.5), new Point(771.5, 796), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(770, 800), new Point(783.5, 791.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(780.5, 794), new Point(793, 794.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(789.5, 795), new Point(797, 803.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(798, 803.5), new Point(804.5, 807.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(805, 808), new Point(797, 821), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(796.5, 817), new Point(811, 840.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(809.5, 832), new Point(804, 854), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(798, 849), new Point(817, 864.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(746, 786.5), new Point(801.5, 813.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(717.5, 787), new Point(804, 831.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(807.5, 847), new Point(687, 784.5), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(658.5, 785.5), new Point(824, 871), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x7B, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(665.5, 810), new Point(792.5, 873.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x69, 0x60);
            sceneRenderer.DrawLine(new Point(191.333, 573.999), new Point(412, 731.333), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x99);
            sceneRenderer.DrawLine(new Point(356, 736.666), new Point(452.667, 799.333), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x99);
            sceneRenderer.DrawLine(new Point(481.333, 768.666), new Point(551.333, 811.999), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x99);
            sceneRenderer.DrawLine(new Point(563.333, 787.333), new Point(506.667, 751.333), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(223, 554), new Point(329, 646.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(199.5, 568.5), new Point(216.5, 563.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(230, 547.5), new Point(214.5, 552), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(248.5, 541), new Point(227.5, 546.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(144, 520), new Point(174, 546.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(176, 547), new Point(186.5, 562.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(184, 557), new Point(205.5, 553.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(202, 536.5), new Point(183, 553), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(125, 508.5), new Point(189.5, 519.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(133.5, 517.5), new Point(160, 513.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(145.5, 514), new Point(129.5, 514), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(186, 518), new Point(197.5, 522), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(193.5, 520.5), new Point(199.5, 540.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(149.5, 517.5), new Point(187, 545), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(194.5, 523.5), new Point(162, 523.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x7C, 0x76, 0x71);
            sceneRenderer.DrawLine(new Point(185.5, 526.5), new Point(192.5, 540.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(211, 576.5), new Point(278.5, 636.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(273, 614.5), new Point(282.5, 644.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(280.5, 644.5), new Point(298.5, 643.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(288.5, 649.5), new Point(322, 673), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(315, 675), new Point(323.5, 673.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(323.5, 669.5), new Point(351.5, 673.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(332.5, 682), new Point(341, 694), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(340, 695.5), new Point(345.5, 696.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(338.5, 685), new Point(367.5, 694), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(356.5, 691.5), new Point(357.5, 701.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(358.5, 707), new Point(383.5, 724.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(386, 711), new Point(358, 699.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(200, 574), new Point(214, 579), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(225, 583.5), new Point(239.5, 589.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(240, 596.5), new Point(261, 611.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(249, 540), new Point(267.5, 563.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(266, 561.5), new Point(267, 578), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(259, 587), new Point(268.5, 582), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(267.5, 576.5), new Point(295.5, 583), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(268.5, 563), new Point(319.5, 603.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(270.5, 588), new Point(285.5, 587), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(285.5, 582.5), new Point(305.5, 596.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(297, 594.5), new Point(300.5, 613), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(298.5, 610.5), new Point(321, 614.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(304, 603), new Point(333.5, 612), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(337, 616), new Point(353.5, 627), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(334, 623), new Point(326, 611), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(344, 623), new Point(333, 639), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(326, 637), new Point(327.5, 632.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(339.5, 637), new Point(322, 653.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(303, 642.5), new Point(316.5, 653), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(295, 647), new Point(325, 665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(347.5, 628.5), new Point(354.5, 644.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(359, 647), new Point(368.5, 637.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(367.5, 644.5), new Point(379, 646), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(378.5, 644), new Point(422, 663.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(333, 644.5), new Point(433, 692.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(431, 692), new Point(516, 747.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x71, 0x68, 0x60);
            sceneRenderer.DrawLine(new Point(341, 677), new Point(383.5, 699.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(389.5, 726.5), new Point(577, 869), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(415, 695.5), new Point(421, 714.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(402, 702), new Point(385, 727), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(438.5, 706), new Point(453, 706), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(448.5, 704.5), new Point(461.5, 699.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(453.5, 711), new Point(465.5, 720.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(469.5, 721), new Point(469.5, 732), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(473.5, 730), new Point(464.5, 749.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(479, 722), new Point(483.5, 735), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(483, 726), new Point(495.5, 726), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(491.5, 727), new Point(485, 754), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(492.5, 723), new Point(497, 764.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(496.5, 745), new Point(524.5, 738.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(527.5, 725), new Point(513.5, 742), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(534, 735.5), new Point(558, 750.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(567.5, 751), new Point(559, 749.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(370.5, 702.5), new Point(394.5, 690), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(397.5, 682), new Point(402.5, 692), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(391.5, 691), new Point(399, 703), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(401, 701), new Point(374.5, 702.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(398, 704), new Point(385, 711.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(388, 714), new Point(376, 714), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(375.5, 698), new Point(387, 689), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x80, 0x75, 0x6A);
            sceneRenderer.DrawLine(new Point(518, 742), new Point(538, 739.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xB3, 0xAF, 0xAB);
            sceneRenderer.DrawLine(new Point(420.333, 792), new Point(521.667, 852.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(82, 548), new Point(22, 559.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x84, 0x69, 0x65);
            sceneRenderer.DrawLine(new Point(90.5, 628), new Point(181, 672), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x84, 0x69, 0x65);
            sceneRenderer.DrawLine(new Point(90, 662.5), new Point(150, 698.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x84, 0x69, 0x65);
            sceneRenderer.DrawLine(new Point(4, 564), new Point(-3, 585.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x84, 0x69, 0x65);
            sceneRenderer.DrawLine(new Point(66, 757), new Point(131, 881), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x84, 0x69, 0x65);
            sceneRenderer.DrawLine(new Point(380, 904), new Point(153, 689), brush, 140f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(226.333, 663.339), new Point(313, 742.672), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(207.667, 668.339), new Point(228.667, 671.006), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(224, 671.339), new Point(224, 685.006), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(224, 685.339), new Point(257.667, 699.006), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(281.667, 719.006), new Point(268.333, 728.339), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(268, 728.339), new Point(292.333, 749.339), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(290.333, 750.339), new Point(314.333, 742.672), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(276, 723.006), new Point(303.333, 745.006), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(241, 703.672), new Point(261.333, 719.339), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(262.333, 719.339), new Point(281.333, 714.006), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(248.333, 700.339), new Point(270.667, 715.672), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(226.333, 674.006), new Point(246.667, 694.672), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(309.333, 740.677), new Point(385.333, 809.343), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(387.667, 813.343), new Point(457.333, 873.677), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(370.333, 829.01), new Point(392, 815.343), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(373.667, 830.343), new Point(389.333, 848.677), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(389.333, 848.677), new Point(422.667, 872.343), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(382, 824.01), new Point(432.667, 870.677), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(316.667, 765.01), new Point(368.333, 815.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(319.333, 813.343), new Point(353.667, 852.677), brush, 35f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(296.667, 788.677), new Point(324, 808.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(313.333, 749.677), new Point(317.333, 768.677), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(227.333, 721.01), new Point(245.667, 744.677), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(251, 749.01), new Point(258.667, 765.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(256.333, 757.677), new Point(256.333, 758.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(257, 759.01), new Point(280, 774.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(217.667, 702.677), new Point(212, 709.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(229.667, 709.343), new Point(224.333, 718.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(259.333, 746.677), new Point(251, 741.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(290.667, 789.677), new Point(281.333, 779.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(228, 780.01), new Point(251.333, 813.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(240.333, 774.01), new Point(311, 845.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(256, 816.01), new Point(303.333, 868.677), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(299.333, 846.343), new Point(333, 865.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(385.667, 854.343), new Point(357.333, 869.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(369.333, 843.677), new Point(359.667, 851.01), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(294.667, 777.01), new Point(301.333, 774.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(273.667, 753.677), new Point(267.667, 754.343), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(274.667, 753.342), new Point(283, 789.009), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(315.333, 787.342), new Point(338, 812.676), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(289.333, 792.009), new Point(311.667, 814.676), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(28, 558.332), new Point(-6, 559.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(63.333, 589.999), new Point(37.333, 573.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(68, 585.999), new Point(73.667, 624.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(72.333, 614.665), new Point(130.667, 630.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(102, 604.665), new Point(114.333, 608.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(120, 614.332), new Point(133.667, 618.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(129.667, 632.999), new Point(169, 633.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(147.333, 611.332), new Point(206.333, 639.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(170.667, 632.999), new Point(200.667, 656.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(197.667, 652.665), new Point(234.333, 652.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(208, 634.332), new Point(227.667, 645.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(157.667, 648.332), new Point(186.333, 669.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(64.333, 626.665), new Point(100.333, 666.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(73, 628.665), new Point(123, 656.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(115.333, 555.665), new Point(157, 605.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(156.667, 596.665), new Point(176.333, 613.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(59, 574.332), new Point(109, 569.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(95.333, 578.332), new Point(129, 588.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.FillRectangle(new Rect(84.667, 580.332, 63.667, 47.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.FillRectangle(new Rect(63, 578.665, 29.333, 33.667), brush);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.FillRectangle(new Rect(2.667, 567.999, 37.333, 46.666), brush);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.FillRectangle(new Rect(33, 566.999, 47.667, 69.333), brush);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(24.333, 546.999), new Point(89, 538.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(75.667, 544.999), new Point(99.667, 557.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(86.667, 536.665), new Point(107.667, 554.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(100.333, 532.999), new Point(117.667, 549.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(116.667, 549.665), new Point(125.667, 548.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(27.333, 560.999), new Point(56.333, 567.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(53.333, 564.999), new Point(59.667, 550.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(92.667, 555.665), new Point(55.333, 562.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x88, 0x78, 0x76);
            sceneRenderer.DrawLine(new Point(86.333, 554.332), new Point(68.667, 554.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(96.667, 631.665), new Point(103.667, 643.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(103, 643.331), new Point(136.333, 643.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(136.667, 643.331), new Point(159, 645.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(142.333, 648.665), new Point(173, 682.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(37, 594.665), new Point(52.667, 610.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(36.667, 565.665), new Point(24.667, 575.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(27.667, 572.998), new Point(-10.333, 581.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(4.333, 594.665), new Point(2.333, 577.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(4.333, 593.331), new Point(17.333, 601.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(15, 601.331), new Point(21, 609.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(18.333, 609.998), new Point(48.333, 611.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(52.333, 607.665), new Point(55, 629.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(55, 629.665), new Point(75.667, 629.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(63, 633.998), new Point(76.333, 646.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(75, 647.665), new Point(83, 667.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(87, 668.665), new Point(108, 653.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(170.333, 681.998), new Point(147, 696.331), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(150.333, 695.668), new Point(167, 724.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(166.333, 725.668), new Point(188, 751.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(196, 749.334), new Point(194, 746.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(186.667, 754.001), new Point(203.333, 774.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(203.667, 774.001), new Point(208.667, 776.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(208.667, 777.001), new Point(223.333, 797.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(223, 797.001), new Point(265, 847.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(261, 850.668), new Point(278.667, 859.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(277.333, 860.334), new Point(284.333, 869.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(77.333, 627), new Point(78, 630.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(38, 591.333), new Point(35, 593.666), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(112, 649), new Point(150, 692), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(80, 692.669), new Point(226, 889.669), brush, 100f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(-26, 610), new Point(61.333, 665.667), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x83, 0x68, 0x64);
            sceneRenderer.DrawLine(new Point(47.667, 670.667), new Point(102.667, 707), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x65, 0x50, 0x4E);
            sceneRenderer.DrawLine(new Point(-30, 702.667), new Point(67.333, 930.667), brush, 80f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(55, 802.166);
                ellipse.RadiusX = 21.333f;
                ellipse.RadiusY = 28.833f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(49, 735);
                ellipse.RadiusX = 29.333f;
                ellipse.RadiusY = 40.333f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(9, 709);
                ellipse.RadiusX = 32.667f;
                ellipse.RadiusY = 26f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(25.917, 755.254);
                ellipse.RadiusX = 7.75f;
                ellipse.RadiusY = 6.417f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(15.75, 762.17);
                ellipse.RadiusX = 2.417f;
                ellipse.RadiusY = 2.334f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(25.667, 774.254);
                ellipse.RadiusX = 3.5f;
                ellipse.RadiusY = 2.917f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(35.292, 785.338);
                ellipse.RadiusX = 9.375f;
                ellipse.RadiusY = 6.667f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(29.083, 790.088);
                ellipse.RadiusX = 4.583f;
                ellipse.RadiusY = 2.917f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(41.334, 777.921);
                ellipse.RadiusX = 7.667f;
                ellipse.RadiusY = 5.417f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(11, 751.004), new Point(15.563, 762.313), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(12.188, 752.063), new Point(21.188, 756.063), brush, 4f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(16.719, 756.813);
                ellipse.RadiusX = 3.156f;
                ellipse.RadiusY = 3f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(89.083, 743.578);
                ellipse.RadiusX = 17.417f;
                ellipse.RadiusY = 13.083f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(67.5, 734.241);
                ellipse.RadiusX = 18.667f;
                ellipse.RadiusY = 20.25f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(56.917, 853.666);
                ellipse.RadiusX = 3.417f;
                ellipse.RadiusY = 4.5f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(52.25, 837.332);
                ellipse.RadiusX = 6.25f;
                ellipse.RadiusY = 5.834f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(106.333, 833.082);
                ellipse.RadiusX = 3.167f;
                ellipse.RadiusY = 2.917f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(93, 809.75);
                ellipse.RadiusX = 3f;
                ellipse.RadiusY = 2.416f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(85.5, 804.582);
                ellipse.RadiusX = 4.5f;
                ellipse.RadiusY = 3.917f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(78.75, 793.416);
                ellipse.RadiusX = 7.25f;
                ellipse.RadiusY = 4.583f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(71.75, 782.332);
                ellipse.RadiusX = 4.75f;
                ellipse.RadiusY = 4.167f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(137.583, 826.416);
                ellipse.RadiusX = 4.583f;
                ellipse.RadiusY = 5.083f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(141.917, 838.499);
                ellipse.RadiusX = 7.25f;
                ellipse.RadiusY = 3f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(87.167, 851.416);
                ellipse.RadiusX = 23.667f;
                ellipse.RadiusY = 14.584f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(82.75, 833.667);
                ellipse.RadiusX = 13.083f;
                ellipse.RadiusY = 16.5f;
                brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(25.667, 773.5), new Point(38.333, 763.833), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(31.167, 770.167), new Point(40.5, 775.167), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(49.667, 824.5), new Point(48.5, 838.167), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(77, 837.333), new Point(54.333, 840), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(71.667, 843.5), new Point(56.833, 851.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(58.833, 853), new Point(71.833, 852), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(93.833, 809.833), new Point(85.833, 821.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(92.333, 809.5), new Point(86.833, 806.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(86.333, 803.333), new Point(81.333, 793.667), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(50.5, 822.333, 22, 15), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(68.833, 796.667, 16.5, 27.5), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(80.667, 807.167, 9.833, 10.666), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(70.5, 783), new Point(78.833, 792.333), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(106.333, 833.167), new Point(93.833, 835.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(105.833, 834), new Point(105.667, 845.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(98, 856.167), new Point(125.333, 868), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(107.167, 851), new Point(119, 851.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(117.167, 851.5), new Point(123, 846.167), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(106.833, 836.833), new Point(114.833, 837.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(115.833, 848.333), new Point(118.167, 842.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(118.167, 842.333), new Point(115.167, 837.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(138.5, 839.5), new Point(127.333, 845.333), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(145.5, 838.333), new Point(138.333, 826.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(148.333, 838.667), new Point(113.5, 777.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(127.833, 800.667), new Point(119.167, 798.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(121, 788.833), new Point(119.5, 798), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(125, 795.833), new Point(123.167, 784.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(123.167, 784.667), new Point(117, 777.167), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(101, 749), new Point(114.667, 781.167), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(117.833, 777.5), new Point(88.167, 754.333), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(139.333, 823.5), new Point(138.667, 813.333), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(102.833, 765), new Point(80, 770.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(80.667, 770.5), new Point(65.167, 779.833), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(93, 752), new Point(55.833, 773.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(85.667, 761.167), new Point(106.5, 759.167), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(148.25, 840.5), new Point(154.25, 845.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(198.75, 828.75), new Point(189.375, 817.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(194.5, 821.25), new Point(182.375, 807.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(192, 817.75), new Point(202.875, 813), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(182.75, 806.125), new Point(169.625, 793.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(158.625, 773.25), new Point(177.375, 800.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(147.125, 762.375), new Point(156.5, 771.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(122.75, 732.375), new Point(112, 740.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(104.25, 739.25), new Point(110.125, 740.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(110.5, 740.375), new Point(104.875, 743.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(115.875, 737.875), new Point(131.625, 733.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(110, 709), new Point(124.25, 723.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(110.625, 710.25), new Point(110.5, 702.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(123.5, 723.25), new Point(131.375, 733.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(126.25, 719.125), new Point(126.5, 734.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(121.25, 719.5), new Point(128.625, 721.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(130.25, 733.25), new Point(135.5, 739.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(135.5, 739.625), new Point(138.75, 745.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(138.875, 745.875), new Point(147.375, 755.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(146.625, 755.375), new Point(152.75, 765.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(157, 770.625), new Point(157, 774), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(163.5, 778.625), new Point(169.125, 780.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(21.125, 619.125), new Point(25.625, 627.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(24.875, 621.375), new Point(30.25, 638.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(30.25, 635.75), new Point(37.25, 640.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(33.5, 640.75), new Point(37.625, 651.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(37.75, 651.5), new Point(39.875, 652.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(39.75, 653), new Point(42.25, 646), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(41.875, 646.75), new Point(36, 642.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(36.625, 643.375), new Point(39.875, 649.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(28.25, 634.25), new Point(24.875, 640.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(25.875, 638.875), new Point(14.5, 635.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(14.375, 635.375), new Point(9.625, 628.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(9.5, 628.25), new Point(0, 630.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(34, 642.25), new Point(25, 644.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(24.875, 644.875), new Point(32, 654.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(30, 654.5), new Point(26.125, 654.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(28, 654.125), new Point(18.625, 648.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(18.625, 650), new Point(17, 655.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(17.375, 655.625), new Point(19.125, 657.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(19.125, 658), new Point(10.875, 659.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(10.125, 660.125), new Point(15.5, 665.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(14.5, 665.875), new Point(24.375, 664.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(23.5, 664.375), new Point(26.5, 672.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(26.375, 672.125), new Point(35.375, 675.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(34.625, 675.375), new Point(44.875, 671), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(32.125, 662.875), new Point(33.125, 665.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(33.25, 665.625), new Point(37.75, 666.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(37.5, 666.875), new Point(45.375, 665.875), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(45.125, 665.875), new Point(47.125, 671.375), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(33, 663.25), new Point(40.75, 658.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(39.375, 660), new Point(61.5, 664.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(60, 664.625), new Point(50.75, 667.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(51.375, 667), new Point(54.625, 676.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(54.375, 676.625), new Point(59, 679.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(58.875, 679.625), new Point(67.5, 678), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(66.5, 677.75), new Point(72.125, 689), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(72, 689), new Point(63.375, 692.625), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(63.375, 692.75), new Point(68.875, 707.125), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(24.125, 637.125, 10.125, 6.625), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(-2.75, 664.25, 25.875, 20.375), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(16.625, 678.125, 47.625, 22.5), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(0, 630.25, 12.625, 40.875), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(7, 637.75, 19.25, 12.75), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(9.375, 649.125, 9.125, 8.625), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(37.375, 673, 18.25, 6.75), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(33.5, 661.75, 21.25, 5.125), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(44.25, 663, 9.125, 12.25), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.FillRectangle(new Rect(62.125, 679.875, 7.5, 10), brush);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x5B, 0x56);
            sceneRenderer.DrawLine(new Point(16.125, 671.625), new Point(38.75, 681.375), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(211, 744.75), new Point(220.25, 765.5), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(198.25, 727.5), new Point(203.75, 741.75), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(171.75, 721.25), new Point(192, 712), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(162.25, 695.75), new Point(166.25, 700.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(215.25, 772.75), new Point(238.5, 763.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(216.75, 739), new Point(205.25, 741.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(161.25, 710.5), new Point(174.25, 698.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(159.75, 693.25), new Point(178, 693), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8D, 0x72, 0x6F);
            sceneRenderer.DrawLine(new Point(195.25, 758.25), new Point(203.5, 754), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(116, 554.329), new Point(126.334, 570.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(127, 570.662), new Point(153.334, 597.996), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(152.334, 595.329), new Point(170, 612.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(145.667, 629.662), new Point(135.667, 618.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(143, 606.662), new Point(131.667, 606.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(114.667, 611.662), new Point(118.334, 609.996), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(119, 604.996), new Point(133.334, 604.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(138, 588.996), new Point(86.334, 594.996), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(59.667, 573.996), new Point(71, 572.329), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(105, 561.662), new Point(73.334, 573.662), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(68.334, 583.329), new Point(86.334, 592.996), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
            sceneRenderer.DrawLine(new Point(110, 569.662), new Point(82.334, 586.662), brush, 20f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(94.834, 601.662);
                ellipse.RadiusX = 14.833f;
                ellipse.RadiusY = 9.334f;
                brush.Color = Color.FromArgb(0xFF, 0xA1, 0x92, 0x93);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(42.875, 554.875);
                ellipse.RadiusX = 8.875f;
                ellipse.RadiusY = 4.875f;
                brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(27.5, 554.25), new Point(37.25, 553), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(50, 552.75), new Point(52.75, 549), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(55.5, 548.5), new Point(66.5, 552.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(66.75, 552.5), new Point(64, 553.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x9B, 0x9C, 0x9E);
            sceneRenderer.DrawLine(new Point(68, 546.25), new Point(67.75, 549.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(144.667, 559.001), new Point(165, 572.001), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(162, 572.001), new Point(176.334, 585.001), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(172.334, 569.334), new Point(174.667, 576.001), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(203.667, 616.667), new Point(234, 637.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(233.334, 637.667), new Point(242, 666.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(242.334, 666.667), new Point(292.667, 712.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(174.334, 579.001), new Point(198.334, 571.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(192.667, 565.667), new Point(186, 567.001), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(177.334, 584.334), new Point(196, 610.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(185.334, 580.001), new Point(246.334, 633.667), brush, 25f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(249.667, 645.001), new Point(297, 688.334), brush, 34f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(288, 660.667), new Point(310, 675.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(236, 652.667), new Point(250.334, 636.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(266.334, 636.667), new Point(253.667, 636.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(304.334, 680.667), new Point(367, 722.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(313.334, 682.001), new Point(328.667, 689.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(322.667, 677.667), new Point(326, 683.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(332.334, 675.001), new Point(332, 681.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(291, 691.001), new Point(359.334, 736.667), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(342, 692.001), new Point(349.667, 697.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(348, 698.334), new Point(348.334, 704.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(349.334, 705.001), new Point(358.334, 704.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(368, 722.667), new Point(379, 727.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(377.334, 726.334), new Point(387.667, 741.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(386, 741.667), new Point(394.334, 740.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(383.334, 726.001), new Point(381.667, 723.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(397.667, 739.334), new Point(393.667, 738.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(386, 736.334), new Point(395.334, 739.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(247.667, 628.667), new Point(258, 628.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(257.667, 628.334), new Point(251, 621.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(295, 707), new Point(499.5, 888.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(316.5, 710.5), new Point(432.5, 806.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(304.5, 689), new Point(325.5, 700.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(325, 699.5), new Point(344, 712), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(351, 714), new Point(373, 733), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(373, 734), new Point(382, 750), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(348, 720.5), new Point(370.5, 742), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(379.5, 752), new Point(400, 751.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(399.5, 751.5), new Point(413.5, 766.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(413.5, 766.5), new Point(425, 770), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(425, 774.5), new Point(436, 779), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(436, 779), new Point(436, 790), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(431, 787.5), new Point(390, 756), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(446, 788.5), new Point(454.5, 797), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(461.5, 796.5), new Point(452.5, 809), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(461, 804.5), new Point(465.5, 813), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(467, 809.5), new Point(471.5, 805), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(429.5, 807.5), new Point(442.5, 822), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(442, 822), new Point(464, 826), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(463, 826), new Point(486, 839.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(486.5, 839.5), new Point(509.5, 851), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(510, 851), new Point(517.5, 845), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(513.5, 841), new Point(529, 852), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(529, 852), new Point(549, 866.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(438, 823), new Point(542, 866.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(453, 838), new Point(525, 873.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(298, 711.5), new Point(288, 705.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(472.5, 806.5), new Point(487, 817.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(486.5, 817.5), new Point(492.5, 823), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(493, 823.5), new Point(501, 826), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(498.5, 825.5), new Point(503.5, 821), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(502, 826.5), new Point(519, 845), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(440.5, 796), new Point(446.5, 793.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9F, 0x9A);
            sceneRenderer.DrawLine(new Point(460.5, 795), new Point(477, 810), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(79, 506), new Point(39, 507.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(71, 503), new Point(103.333, 530.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(55.667, 510.334), new Point(110, 550), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(103.667, 529), new Point(114.667, 536.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(125.667, 547), new Point(113.333, 534.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(126, 548.334), new Point(144, 566.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(144, 566.667), new Point(158.667, 579), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(158.667, 578.667), new Point(181.667, 600), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(150.667, 573.667), new Point(168.667, 592.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(178.333, 597.667), new Point(191.667, 618.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(189, 617.334), new Point(206.333, 626.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(194.333, 620), new Point(201.333, 612.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x59);
            sceneRenderer.DrawLine(new Point(195.333, 616.334), new Point(184, 618.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(25.333, 539), new Point(80, 532.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(97, 525), new Point(47.667, 532.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(87, 525), new Point(40.667, 526.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(53.333, 504.334), new Point(56, 521.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(70.667, 524), new Point(49, 517), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(53.667, 504.334), new Point(36.667, 510.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x4C, 0x40);
            sceneRenderer.DrawLine(new Point(43, 508.334), new Point(55, 532), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(-8.333, 473), new Point(28.333, 540.334), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(52, 531), new Point(51.667, 524.334), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(31.333, 535), new Point(48.667, 528.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(33.333, 513.667), new Point(44, 514), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(3.667, 548.667), new Point(2, 521.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(6.667, 472), new Point(-5.667, 419.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(42, 512.334), new Point(49.333, 516.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(33.667, 511), new Point(37.667, 498.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(37.667, 499), new Point(27.667, 499), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(35, 505.667), new Point(29.333, 500), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(26, 499.334), new Point(28.333, 488.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(31, 489.334), new Point(19.667, 489), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(315, 737), new Point(394, 813), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(395, 810.5), new Point(454.5, 865.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x97, 0x72, 0x6E);
            sceneRenderer.DrawLine(new Point(375, 808), new Point(400, 811.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x90, 0x89, 0x82);
            sceneRenderer.DrawLine(new Point(229, 636.5), new Point(240, 671), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(175, 627.5), new Point(155, 649.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(26.5, 545), new Point(-5.5, 545.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x35, 0x30, 0x2B);
            sceneRenderer.DrawLine(new Point(36, 501), new Point(41, 509), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x5A);
            sceneRenderer.DrawLine(new Point(82.5, 544), new Point(101, 549.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x66, 0x5A);
            sceneRenderer.DrawLine(new Point(118.5, 551), new Point(102.5, 558), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA3, 0x93, 0x94);
            sceneRenderer.DrawLine(new Point(117.5, 576.5), new Point(104.5, 562), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA3, 0x93, 0x94);
            sceneRenderer.DrawLine(new Point(130.5, 562), new Point(161.5, 590), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x8A, 0x79, 0x77);
            sceneRenderer.DrawLine(new Point(177, 607), new Point(183, 622), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8A, 0x83);
            sceneRenderer.DrawLine(new Point(192, 609.5), new Point(210.5, 608), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8A, 0x83);
            sceneRenderer.DrawLine(new Point(150, 568), new Point(172.5, 578.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8A, 0x83);
            sceneRenderer.DrawLine(new Point(187, 577), new Point(174.5, 587), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8A, 0x83);
            sceneRenderer.DrawLine(new Point(206, 605), new Point(202, 620), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x8A, 0x83);
            sceneRenderer.DrawLine(new Point(208, 615.5), new Point(208.5, 634), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(415.5, 719.5), new Point(459.5, 745.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(448, 751.5), new Point(455.5, 766), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(448.5, 758), new Point(445, 769), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(444.5, 769), new Point(440, 775), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(457, 760.5), new Point(492, 762), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(420, 714), new Point(412.5, 724), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(440, 712.5), new Point(454, 715.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(481.5, 734), new Point(475, 747.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(475.5, 747.5), new Point(461, 754), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(484.5, 739.5), new Point(490, 741.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(468, 753.5), new Point(485, 753.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(485.5, 753.5), new Point(490, 757.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(471.5, 761.5), new Point(470, 776.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(470.5, 776.5), new Point(477.5, 785), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(473.5, 774.5), new Point(504, 763), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(448.5, 749.5), new Point(460.5, 757.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(496, 749.5), new Point(522, 745), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(507, 747.5), new Point(506.5, 762), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(508, 755.5), new Point(567.5, 754), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(486.5, 771), new Point(497, 790.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(494.5, 786.5), new Point(492, 803), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(492, 803.5), new Point(511.5, 804), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(504.5, 805), new Point(513.5, 814), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(524.5, 742.5), new Point(556.5, 750), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(536.5, 745.5), new Point(522.5, 752), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(412, 738), new Point(442, 759.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(464, 732.5), new Point(450, 712.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(458, 734), new Point(458.5, 756.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(467.5, 755), new Point(497, 797.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x89, 0x80, 0x77);
            sceneRenderer.DrawLine(new Point(448.5, 763.5), new Point(504, 761.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(504, 780), new Point(507, 804), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(507.5, 801), new Point(516.5, 801), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(516, 804.5), new Point(527, 805.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(490.5, 771.5), new Point(495.5, 778), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(501, 767.5), new Point(503, 773.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(505, 781.5), new Point(516, 757.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(516, 759), new Point(539.5, 772), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(539.5, 771.5), new Point(540, 758.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(540, 758), new Point(547, 758), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(547, 760), new Point(552.5, 772), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(559, 759), new Point(567, 761), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(564, 763), new Point(584, 767.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(562, 764.5), new Point(555, 769), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(581, 779), new Point(504.5, 786.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(541.5, 783), new Point(547.5, 788), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(546.5, 779), new Point(553.5, 797), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(551, 785.5), new Point(561, 782), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(559.5, 782), new Point(590, 770), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(590.5, 769), new Point(616.5, 786.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(526, 813), new Point(544.5, 807), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(544, 807), new Point(557.5, 790.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(528, 813), new Point(545, 830.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(545, 830.5), new Point(553, 847), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(556, 851.5), new Point(579, 853.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(572.5, 852), new Point(596.5, 875), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(551.5, 838.5), new Point(566.5, 852), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(544, 805.5), new Point(624.5, 867.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(577.5, 774), new Point(602, 826.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(670, 817), new Point(627, 846.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(555, 796), new Point(629.5, 806.5), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x96, 0x8D, 0x85);
            sceneRenderer.DrawLine(new Point(603.5, 829.5), new Point(630.5, 831), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(678, 823.5), new Point(637.5, 853.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(680, 834.5), new Point(701.5, 848.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(629.5, 857.5), new Point(656.5, 864.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(742, 865.5), new Point(702, 844.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(725, 863), new Point(651, 853), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(670.5, 851), new Point(678, 829), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(627, 795), new Point(656, 823.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(614, 814.5), new Point(639, 834), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(608, 785.5), new Point(625, 793.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(626.5, 794), new Point(615.5, 802), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(615.5, 802), new Point(641, 823), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(619, 809.5), new Point(610, 813.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(601, 824.5), new Point(616, 824), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(602, 833.5), new Point(624.5, 833), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(620.5, 833), new Point(625.5, 846), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(626.5, 846.5), new Point(631.5, 840), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(597.5, 836), new Point(606.5, 830), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(640.5, 793), new Point(646, 802.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(652.5, 805), new Point(668, 817), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(656, 806), new Point(671.5, 802), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(666, 805.5), new Point(675.5, 812), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(676.5, 819), new Point(686.5, 823), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0xAD, 0xA3);
            sceneRenderer.DrawLine(new Point(697.5, 825), new Point(692.5, 831), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(673.5, 797), new Point(681, 805.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(649, 787.5), new Point(654, 803), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(653.5, 800.5), new Point(667, 799.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(665, 800), new Point(674.5, 800), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(647, 790), new Point(633.5, 786), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(657.5, 783.5), new Point(657.5, 788.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(672, 813.5), new Point(681, 815), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(680, 817.5), new Point(684.5, 816.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(676.5, 803), new Point(676.5, 812), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xA1, 0x88, 0x70);
            sceneRenderer.DrawLine(new Point(677, 813), new Point(662, 820), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(272.5, 502.5), new Point(477.25, 634), brush, 50f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(277.25, 537.25), new Point(297, 556.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(296.5, 556.25), new Point(318.25, 556.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(313, 557), new Point(318.25, 570), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(316.5, 569), new Point(342, 579), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(277, 541), new Point(264.5, 539.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(265.5, 539), new Point(249, 519.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(248.25, 523.25), new Point(235.75, 486.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(338.25, 578.25), new Point(356, 587.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(353.25, 587.5), new Point(386.5, 605.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(384.75, 606), new Point(402, 619), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(401, 619.75), new Point(404.75, 629.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(407, 628.25), new Point(415, 635), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(401, 616.75), new Point(426.25, 638), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(424.25, 633.5), new Point(429.75, 633.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(445.75, 640.5), new Point(449.75, 653.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(452, 650.5), new Point(470.25, 658.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(464, 658.75), new Point(486.5, 678.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(493.5, 677), new Point(518.25, 704.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(557.75, 709.75), new Point(616.5, 689.25), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(619.25, 705.5), new Point(644.75, 715), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(654.25, 714), new Point(684.75, 714.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(655.25, 712.75), new Point(643, 719.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(642.75, 709.25), new Point(663, 719.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(618, 711.75), new Point(595.75, 716.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(486.5, 671.25), new Point(494.5, 687.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(465, 635.75), new Point(493.25, 672.5), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x28, 0x27, 0x23);
            sceneRenderer.DrawLine(new Point(533.5, 710), new Point(549, 721.75), brush, 14f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(491.167, 547.832);
                ellipse.RadiusX = 42.5f;
                ellipse.RadiusY = 48.5f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(555.5, 690.998);
                ellipse.RadiusX = 22.833f;
                ellipse.RadiusY = 37.666f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(538, 562.332), new Point(579.667, 659.665), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(512, 529.999), new Point(542, 567.999), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(578.667, 650.999), new Point(575.667, 689.332), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(581.333, 645.999), new Point(631, 693.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(335.333, 523.332), new Point(424.667, 574.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(461.667, 544.665), new Point(445.667, 569.999), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(446.333, 566.665), new Point(438.333, 606.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(494, 661.999), new Point(530.333, 704.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(526.333, 701.332), new Point(549, 712.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(362.667, 558.332), new Point(427.333, 575.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(485.667, 612.999), new Point(456.667, 627.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(483, 621.665), new Point(490.667, 664.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(655.667, 702.332), new Point(627.333, 698.332), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(404.667, 575.332), new Point(414.333, 598.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(319.667, 528.999), new Point(340, 542.999), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(448.333, 584.332), new Point(486, 600.332), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(318.667, 524.332), new Point(335.667, 523.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(332.333, 516.999), new Point(339.333, 523.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(339, 550.665), new Point(354, 554.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(342.333, 537.332), new Point(361, 554.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(350.667, 562.999), new Point(359.667, 567.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(358.333, 562.332), new Point(363.333, 557.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(365.667, 568.332), new Point(380.333, 574.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(379.667, 580.665), new Point(397.667, 577.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(398, 581.999), new Point(403, 591.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(418.333, 580.332), new Point(436, 615.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(432.333, 582.665), new Point(413, 612.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(423.667, 618.665), new Point(446.667, 605.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(448.333, 623.999), new Point(475.667, 642.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(466, 649.999), new Point(469.333, 650.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(472.667, 645.332), new Point(478, 656.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(605, 701.665), new Point(621.333, 701.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(606.667, 690.332), new Point(630, 704.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(608.333, 665.665), new Point(651, 681.999), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(629.333, 685.999), new Point(648, 688.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(722.333, 654.665), new Point(640.333, 687.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(629.333, 676.665), new Point(681, 672.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(731.667, 646.999), new Point(717.333, 653.999), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(721.667, 656.332), new Point(733.333, 646.665), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(652, 704.999), new Point(666.333, 697.999), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(666.667, 695.999), new Point(653, 695.999), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(654.667, 698.665), new Point(665.333, 698.665), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(419, 608.665), new Point(418, 617.999), brush, 4f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(263.25, 500.25);
                ellipse.RadiusX = 24f;
                ellipse.RadiusY = 37f;
                brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(277.75, 537.5), new Point(277.25, 521.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x17, 0x14, 0x14);
            sceneRenderer.DrawLine(new Point(263.75, 530.25), new Point(278.75, 537.5), brush, 5f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(232.375, 465.75);
                ellipse.RadiusX = 5.125f;
                ellipse.RadiusY = 5f;
                brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(231.5, 463.75), new Point(241.75, 501), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(232.75, 466), new Point(251.25, 473.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(233.25, 467.75), new Point(247.75, 482.5), brush, 10f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(300, 499.125);
                ellipse.RadiusX = 12.5f;
                ellipse.RadiusY = 12.625f;
                brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(288.875, 507.5);
                ellipse.RadiusX = 4.625f;
                ellipse.RadiusY = 5f;
                brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(308.25, 502.75), new Point(318.75, 500.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(318.75, 500.5), new Point(367.75, 527), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(366.75, 528.5), new Point(431.25, 564.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(310, 496.75), new Point(322.25, 501), brush, 3f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(451.875, 613.75);
                ellipse.RadiusX = 12.375f;
                ellipse.RadiusY = 6.25f;
                brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(439.125, 622.875);
                ellipse.RadiusX = 7.875f;
                ellipse.RadiusY = 3.875f;
                brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x58, 0x57, 0x56);
            sceneRenderer.DrawLine(new Point(453, 613.75), new Point(442, 621.25), brush, 10f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(541.667, 665.334);
                ellipse.RadiusX = 26f;
                ellipse.RadiusY = 38f;
                brush.Color = Color.FromArgb(0xFF, 0x61, 0x5F, 0x62);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(508.833, 601.667);
                ellipse.RadiusX = 25.833f;
                ellipse.RadiusY = 34f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(514.667, 634);
                ellipse.RadiusX = 23f;
                ellipse.RadiusY = 34.667f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(535.833, 663.167);
                ellipse.RadiusX = 29.5f;
                ellipse.RadiusY = 31.5f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(541.333, 687);
                ellipse.RadiusX = 19.667f;
                ellipse.RadiusY = 12.334f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(488.667, 608.667), new Point(498.667, 649.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(501, 654.667), new Point(516.333, 680.667), brush, 9f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(519.5, 618.334);
                ellipse.RadiusX = 24.167f;
                ellipse.RadiusY = 41.333f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(503, 592.168);
                ellipse.RadiusX = 26.667f;
                ellipse.RadiusY = 22.167f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(532, 663.834);
                ellipse.RadiusX = 15.333f;
                ellipse.RadiusY = 17.833f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(551.667, 691.167);
                ellipse.RadiusX = 6.667f;
                ellipse.RadiusY = 3.5f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(551, 665.167);
                ellipse.RadiusX = 12.667f;
                ellipse.RadiusY = 21.5f;
                brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(556.333, 636.334), new Point(559, 661.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(531.333, 677.334), new Point(550, 680.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(505.667, 644.001), new Point(523.667, 672.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(561, 672.334), new Point(554, 690.001), brush, 9f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(525.167, 618.668);
                ellipse.RadiusX = 26.833f;
                ellipse.RadiusY = 35.333f;
                brush.Color = Color.FromArgb(0xFF, 0x72, 0x74, 0x79);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(536.5, 642.5);
                ellipse.RadiusX = 24.5f;
                ellipse.RadiusY = 34.167f;
                brush.Color = Color.FromArgb(0xFF, 0x72, 0x74, 0x79);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(530.667, 633.001);
                ellipse.RadiusX = 28f;
                ellipse.RadiusY = 37f;
                brush.Color = Color.FromArgb(0xFF, 0x72, 0x74, 0x79);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x55, 0x57);
            sceneRenderer.DrawLine(new Point(516.667, 600.001), new Point(501.333, 600.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xA0, 0xA8);
            sceneRenderer.DrawLine(new Point(513, 598.001), new Point(532, 597.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xA0, 0xA8);
            sceneRenderer.DrawLine(new Point(526.334, 597.001), new Point(542, 619.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xA0, 0xA8);
            sceneRenderer.DrawLine(new Point(544, 617.334), new Point(548.334, 644.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xA0, 0xA8);
            sceneRenderer.DrawLine(new Point(550.334, 641.001), new Point(545.334, 659.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0xA0, 0xA8);
            sceneRenderer.DrawLine(new Point(530.334, 593.001), new Point(539.334, 627.667), brush, 9f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(515, 616.334);
                ellipse.RadiusX = 13.334f;
                ellipse.RadiusY = 19.333f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(535.333, 657.334);
                ellipse.RadiusX = 11f;
                ellipse.RadiusY = 13.667f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(520.167, 630.334);
                ellipse.RadiusX = 15.5f;
                ellipse.RadiusY = 23.667f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(526.333, 634.834);
                ellipse.RadiusX = 13.667f;
                ellipse.RadiusY = 23.5f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(529.833, 643.834);
                ellipse.RadiusX = 14.5f;
                ellipse.RadiusY = 25.833f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(515.5, 625.168);
                ellipse.RadiusX = 12.833f;
                ellipse.RadiusY = 22.166f;
                brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x4E, 0x46, 0x41);
            sceneRenderer.DrawLine(new Point(512.667, 648.001), new Point(523.333, 663.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(588.666, 670), new Point(582, 721.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(597.666, 679), new Point(598.666, 717), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(483, 555.667), new Point(500, 545), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(500.333, 545), new Point(516, 546.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(515.667, 546.333), new Point(532, 557), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(532, 557), new Point(549.667, 578.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(549, 578.333), new Point(565, 609.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(566.333, 608.333), new Point(575, 624), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(574.667, 624.667), new Point(574.667, 640.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(576.333, 621.333), new Point(583.333, 646), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(573, 637), new Point(581, 675.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(581.666, 640), new Point(593.333, 671.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(565.333, 726.333), new Point(606, 712.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(593, 670.667), new Point(610.666, 686), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(577.667, 641.333), new Point(587.666, 673), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(606, 708.333), new Point(618, 709.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(622, 703.333), new Point(621, 715.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(619.666, 711.667), new Point(637.333, 711.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(634.666, 713), new Point(648.666, 719.333), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(647, 720.667), new Point(626, 716), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(639, 715), new Point(656.333, 712.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(655.333, 712.667), new Point(665.666, 715), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(663.333, 716.333), new Point(685, 711.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(485, 555.667), new Point(479.333, 560.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(510, 540.667), new Point(495.667, 544), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1D);
            sceneRenderer.DrawLine(new Point(508.333, 539.667), new Point(525, 548), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(267.75, 299.25), new Point(323.5, 290.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(324, 287.25), new Point(263.5, 294.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(277.25, 260.25), new Point(264.5, 296.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(265.75, 293), new Point(265.5, 331.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(265.5, 314.5), new Point(260.75, 331.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(287.5, 243.5), new Point(273, 260), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(286.5, 244.5), new Point(299, 236.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(299, 236), new Point(314.75, 232.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(315, 232.75), new Point(326.25, 233.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(291.5, 252), new Point(277.5, 262), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(288.25, 254.5), new Point(278.25, 269.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(277.25, 271.25), new Point(273.25, 292), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(322.75, 261.25), new Point(323.5, 286), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(323.25, 245.75), new Point(320.25, 286.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(331.25, 262), new Point(332.5, 282.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(332, 279.5), new Point(321.5, 300.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(325, 291.75), new Point(397, 276.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(324.25, 235.5), new Point(389, 256.25), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(331.25, 281.75), new Point(345, 284), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(323.75, 235), new Point(320.75, 245.75), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(322.25, 244), new Point(330.25, 247.25), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(352.5, 227), new Point(357.25, 240.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(390.75, 250.5), new Point(359.25, 234), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(376, 255.25), new Point(389.5, 275.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(385.5, 250), new Point(394.5, 273.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(336.25, 293), new Point(353.5, 318.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(339.75, 303.5), new Point(371, 303.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(355, 304.5), new Point(380, 292.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(376.25, 293), new Point(401.5, 293.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(390.5, 278.5), new Point(399.25, 292.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(347.75, 315.25), new Point(397, 298.75), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(329.5, 293.5), new Point(328.75, 342.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x34, 0x26, 0x25);
            sceneRenderer.DrawLine(new Point(343.5, 303.75), new Point(342, 349.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(315.25, 299.5), new Point(313, 347), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(311.75, 303.5), new Point(287.5, 306.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(287.75, 306.5), new Point(271.25, 313.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(271, 313.5), new Point(271, 332.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(263.75, 333.5), new Point(317.5, 346.25), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(274.75, 320.5), new Point(313.25, 316.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(276, 322.75), new Point(312, 334.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(378, 309.25), new Point(349, 330.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(352, 320.5), new Point(356, 335), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(403, 315.25), new Point(362, 343.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(376, 292.5), new Point(386.75, 315.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(378.75, 306.25), new Point(385, 317.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(383.5, 292.75), new Point(392.75, 310.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(385.5, 305), new Point(390.25, 313.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(388.75, 296.5), new Point(395.5, 309.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(393.5, 291.75), new Point(396.5, 305.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x37, 0x39, 0x38);
            sceneRenderer.DrawLine(new Point(397.75, 292.75), new Point(396.25, 311), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x82, 0x74, 0x71);
            sceneRenderer.DrawLine(new Point(271.5, 333.75), new Point(313.25, 344.75), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x82, 0x74, 0x71);
            sceneRenderer.DrawLine(new Point(279.25, 335.5), new Point(305, 341), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x82, 0x74, 0x71);
            sceneRenderer.DrawLine(new Point(260.5, 334), new Point(317.75, 349.5), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x82, 0x74, 0x71);
            sceneRenderer.DrawLine(new Point(258.75, 342.75), new Point(320.5, 362), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x82, 0x74, 0x71);
            sceneRenderer.DrawLine(new Point(321.75, 364.75), new Point(412.75, 385.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(343.75, 344), new Point(373.25, 339.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(370.5, 339), new Point(411, 350.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(365, 348.75), new Point(406.5, 350), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(393.5, 342), new Point(397.75, 333.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(397.75, 336), new Point(405, 328.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(403.25, 304.25), new Point(408.75, 354.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x6F, 0x6D, 0x6C);
            sceneRenderer.DrawLine(new Point(384, 360.75), new Point(427, 364.5), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x48, 0x46);
            sceneRenderer.DrawLine(new Point(326.25, 326), new Point(326.25, 348.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x48, 0x46);
            sceneRenderer.DrawLine(new Point(328, 340.25), new Point(335, 359.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x48, 0x46);
            sceneRenderer.DrawLine(new Point(335, 350.25), new Point(355.25, 351.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x54, 0x48, 0x46);
            sceneRenderer.DrawLine(new Point(336.75, 362), new Point(381.75, 359.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(339, 342.25), new Point(361.25, 345.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(355.5, 352.75), new Point(411.75, 353.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(372.75, 351.75), new Point(356.5, 348.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(351, 338.75), new Point(376.75, 341.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(354, 342.75), new Point(380.5, 344.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(378.75, 344.25), new Point(358.75, 349.25), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(359.25, 346.25), new Point(380.25, 340.75), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xC9, 0xCA, 0xCD);
            sceneRenderer.DrawLine(new Point(374.75, 339.75), new Point(361.75, 339), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(439.333, 471.665), new Point(434.667, 552.332), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(465.333, 497.665), new Point(442.333, 543.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(499.333, 490.332), new Point(455.667, 501.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(480.667, 493.665), new Point(458.333, 508.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(443.667, 547.665), new Point(434.667, 564.998), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(434, 560.332), new Point(430.667, 582.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(323, 302.334), new Point(321, 350.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(321, 331.668), new Point(326, 357.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(384, 357.668), new Point(356.667, 368.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(356.667, 368.001), new Point(393.667, 377.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(323.667, 351.334), new Point(335.667, 356.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(333.333, 362.668), new Point(360.667, 371.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(334.333, 353.668), new Point(338.333, 363.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(333.667, 361.334), new Point(274.667, 344.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(290, 347.668), new Point(334.333, 356.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(263, 350.334), new Point(310.667, 364.001), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(388.667, 366.334), new Point(366.667, 368.001), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(334.667, 383.001), new Point(273.333, 371.334), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(332, 362.001), new Point(306.333, 364.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(258.333, 392), new Point(257.333, 443), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(325.333, 388.333), new Point(325, 464), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(230.667, 371), new Point(234, 454), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(265, 365.667), new Point(297.667, 466.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(299.667, 395), new Point(277.333, 464), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(223, 408.667), new Point(219, 425), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(212.667, 441.667), new Point(223.667, 452.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(217.667, 423), new Point(217.667, 446.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(222.667, 419.667), new Point(221.333, 449), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x66, 0x45, 0x42);
            sceneRenderer.DrawLine(new Point(230.333, 448.334), new Point(238.333, 460), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(280, 230.75), new Point(306.75, 225), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(397.25, 264.75), new Point(415.5, 323.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(400.5, 294.25), new Point(403.75, 309.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(410, 308), new Point(408, 320.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(408, 320.25), new Point(422, 356), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(414.75, 321.25), new Point(428.25, 362.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(426, 360.75), new Point(423.75, 380.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(420, 352.75), new Point(424, 361.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(412.5, 356), new Point(412.75, 366), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(411, 366.5), new Point(403, 374.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(385.5, 369.75), new Point(405.75, 374.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(380.25, 358.5), new Point(388.75, 365.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(393.75, 374.75), new Point(435.5, 384.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(428.75, 363.25), new Point(442.25, 414.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(408.25, 406.25), new Point(434, 405.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(434, 395.5), new Point(374.25, 386.75), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(422.75, 373.5), new Point(390.5, 370.5), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(379.75, 249.5), new Point(395.5, 270.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(299.75, 233.5), new Point(288, 232), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(293.25, 228.75), new Point(282, 236), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(605, 236.25), new Point(396.5, 255.75), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(398.75, 264.25), new Point(390, 244), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(407, 252.5), new Point(390.25, 252.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(391.5, 246), new Point(372, 231), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(304.25, 226.5), new Point(335.75, 224.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(303.25, 223), new Point(351, 226.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(337.5, 223), new Point(373.75, 232), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(372.5, 230.5), new Point(350, 222), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(317.5, 213.5), new Point(350.75, 219.25), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(302, 214.75), new Point(332.5, 216.25), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(376.5, 247), new Point(386, 255.75), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(379.5, 240), new Point(391.5, 253.75), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(225.5, 465.5), new Point(231.25, 493.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(226.25, 453.25), new Point(226.25, 466.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(225.5, 454.25), new Point(231.25, 454), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(228.5, 454.5), new Point(234.25, 459.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(227.25, 459.25), new Point(261.5, 466), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(238.5, 458.75), new Point(255, 473), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(251.5, 469), new Point(273, 470.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(261.25, 465.5), new Point(278.5, 465.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(274.25, 465.75), new Point(320, 493.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(222.5, 373), new Point(224.25, 384.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(223.5, 379.75), new Point(252.75, 420.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(224.25, 382.5), new Point(230.75, 401.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(228.5, 398.5), new Point(250, 421.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(237, 368.5), new Point(238.5, 398.5), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(230.25, 363.25), new Point(226.5, 373), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(230.5, 363.75), new Point(233.75, 372.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(230, 366.5), new Point(257.5, 360.75), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(247.5, 345.75), new Point(251, 360.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(249.75, 355), new Point(244.25, 363.25), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(256.75, 343), new Point(248.5, 347), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(247.75, 331.25), new Point(259.75, 338.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(259.5, 339.25), new Point(277, 344.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(293.5, 344.75), new Point(274.75, 341.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(254.5, 333.5), new Point(276.5, 343), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(260.75, 340.25), new Point(257.5, 346.5), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(273.75, 358.75), new Point(273.75, 375.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(267, 399), new Point(266.25, 431.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(265.75, 429.25), new Point(269.5, 449.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(251, 418.5), new Point(260, 448.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(258, 367.5), new Point(267, 401.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(274.75, 358.25), new Point(264.5, 360.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(264.5, 360.25), new Point(256, 368), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(262.5, 349.75), new Point(256.25, 358.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(250, 349.5), new Point(262.5, 362.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(273.25, 382.75), new Point(290.25, 385.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(285.25, 384.25), new Point(289, 396), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(286.5, 392.5), new Point(317, 417.25), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(288.25, 386), new Point(300.5, 391.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(294.75, 389.25), new Point(314.25, 407), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(317.25, 397.5), new Point(301.5, 397.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(315.5, 401.5), new Point(314.5, 425), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(251.5, 361.5), new Point(260, 403.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(255.5, 413.25), new Point(250.5, 372.25), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(245, 362.25), new Point(246.75, 398.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(241.75, 396.25), new Point(246.25, 416.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(233.75, 421), new Point(246.75, 439), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(238.75, 415.25), new Point(252.25, 436), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(240.25, 440.75), new Point(253.25, 464.75), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(237.5, 440), new Point(270.25, 454), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(251.25, 437.25), new Point(270.5, 449), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(251, 455.5), new Point(285, 468.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(282.25, 466.25), new Point(299.25, 466.25), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(284.75, 448.25), new Point(299.5, 446), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(288.75, 444.75), new Point(311.25, 449), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(289.75, 448.5), new Point(315.75, 444), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(316, 428.75), new Point(311.5, 447.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(311, 447), new Point(312.25, 459.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(311.5, 458.5), new Point(310, 477.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(309.25, 476.25), new Point(292.75, 476.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(290, 469.5), new Point(311.25, 470.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(318.75, 376), new Point(318.5, 478.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(304.75, 478.5), new Point(311.25, 484), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(311.5, 483.25), new Point(323.75, 487), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(319.25, 487.75), new Point(438, 556.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(332.5, 389.5), new Point(355.25, 450.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(340.5, 410.5), new Point(340.25, 471), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(338, 447.25), new Point(323, 486.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(332.75, 375.25), new Point(380.25, 388.25), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(328.25, 386.25), new Point(377, 403), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x3E, 0x14, 0x17);
            sceneRenderer.DrawLine(new Point(364.75, 400.5), new Point(360.5, 505.5), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(648.334, 518), new Point(724, 536), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(720.334, 555.667), new Point(746, 629), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(375, 506.334), new Point(430.667, 536.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(344, 497), new Point(380.333, 507.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(392.667, 394.667), new Point(392.333, 426.334), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(419, 446.667), new Point(413.333, 527), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(396.667, 432.667), new Point(409.667, 490.667), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(404.333, 432.667), new Point(436.667, 431.667), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(374.667, 504), new Point(397.667, 500), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(376, 441.334), new Point(388.667, 471.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(367.333, 420.334), new Point(379.667, 439), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(377, 469.667), new Point(394, 482), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(382.333, 484), new Point(391.333, 494.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(440.667, 413.334), new Point(441, 477.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(436.667, 368), new Point(450.667, 416.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(449.667, 411), new Point(448, 531.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(453.333, 404), new Point(625.667, 465.667), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(467, 377.334), new Point(505.333, 484), brush, 60f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(451.333, 497), new Point(481.333, 477.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x50, 0x17, 0x1D);
            sceneRenderer.DrawLine(new Point(448.667, 427), new Point(466.333, 492), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(371.667, 411.667), new Point(367, 422), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(369, 417.667), new Point(378, 430), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(375, 427), new Point(383.667, 443), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(382, 443.334), new Point(387, 453), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(384.667, 452.667), new Point(403.667, 454.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(401.667, 455), new Point(414.667, 451.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(376.333, 399), new Point(379.667, 420.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(379, 403.334), new Point(388, 411.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(385.667, 402.667), new Point(395, 413.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(393, 410.667), new Point(399.667, 413), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(413, 451.334), new Point(430.333, 453.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(430, 454), new Point(434.333, 447.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(434.333, 448.334), new Point(430.333, 443), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(433.333, 443), new Point(419.667, 441.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(419.667, 441), new Point(419.667, 435), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(387, 411.334), new Point(407.667, 429.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(405.667, 429.334), new Point(421, 435.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(432, 446.334), new Point(383, 446), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(380.667, 409.334), new Point(420.667, 447), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x64, 0x2C, 0x2E);
            sceneRenderer.DrawLine(new Point(379.333, 421.667), new Point(399.667, 445.667), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x16, 0x25);
            sceneRenderer.DrawLine(new Point(713.334, 507.334), new Point(732, 545.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x16, 0x25);
            sceneRenderer.DrawLine(new Point(715.667, 537.334), new Point(746.667, 584), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x85, 0x16, 0x25);
            sceneRenderer.DrawLine(new Point(734.667, 537.667), new Point(755, 617.667), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(717.667, 503.334), new Point(749.334, 545.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(737.334, 531.667), new Point(756.334, 574), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(756.667, 573), new Point(761.334, 583.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(760.334, 584), new Point(760.334, 610), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(754.334, 525.334), new Point(777.334, 602.667), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(891.667, 510.334), new Point(884.334, 543.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(887, 539.667), new Point(874.667, 552.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(874.667, 551), new Point(868.334, 501.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(881, 483.667), new Point(871.334, 504), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(890.667, 482.334), new Point(872.667, 502), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(889.667, 483.667), new Point(887.667, 512.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(895.667, 485), new Point(889.667, 500.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC1, 0x3A, 0x49);
            sceneRenderer.DrawLine(new Point(882, 490), new Point(879, 541), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0x2D, 0x2B, 0x2A);
            sceneRenderer.DrawLine(new Point(864.333, 524.334), new Point(775.666, 563.334), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x2D, 0x2B, 0x2A);
            sceneRenderer.DrawLine(new Point(858, 540), new Point(777.75, 572), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(773.333, 546.668), new Point(776.666, 577.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(775, 565.001), new Point(784.333, 591.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(773.666, 575.334), new Point(779.333, 592.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(776, 587.334), new Point(784.666, 597.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(773.666, 578.001), new Point(774, 548.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(773.666, 547.668), new Point(805, 524.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(793, 532.668), new Point(850.333, 507.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(854, 502.001), new Point(817.333, 513.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(839.333, 503.001), new Point(866.333, 502.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(863, 500.001), new Point(865.666, 521.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(865.666, 521.668), new Point(865.666, 533.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(845.666, 507.334), new Point(860.666, 510.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(859.666, 510.001), new Point(863.666, 534.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(798.666, 530.334), new Point(802.666, 540.668), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(847.666, 509.668), new Point(846.333, 521.334), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(775, 548.001), new Point(817.666, 538.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(818, 538.001), new Point(832.666, 533.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(831.333, 526.334), new Point(826.666, 534.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(829, 528.668), new Point(842, 526.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(841.666, 526.334), new Point(859, 514.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(855.333, 506.334), new Point(863, 514.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(861.666, 512.334), new Point(862, 522.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(861.666, 520.334), new Point(842.666, 536.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(844, 535.668), new Point(838.666, 538.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(831, 537.001), new Point(820.666, 544.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(830.666, 536.668), new Point(827, 546.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(822.333, 545.668), new Point(808.666, 551.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(810, 551.001), new Point(789.666, 556.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(794, 557.001), new Point(776, 559.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(778.333, 558.001), new Point(774.333, 554.668), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(834.333, 535.668), new Point(819.333, 558.668), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(822.666, 556.001), new Point(808.666, 562.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(813.333, 560.334), new Point(805.333, 560.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(807.333, 560.001), new Point(798.666, 565.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(803, 562.668), new Point(778.666, 569.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(820.333, 556.334), new Point(836.666, 552.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(835.666, 552.334), new Point(843.666, 550.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(840.333, 550.668), new Point(860, 532.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(859.333, 532.001), new Point(867, 532.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(858, 535.668), new Point(867, 536.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(866.666, 534.334), new Point(849.333, 553.668), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(849.333, 554.001), new Point(838.666, 560.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(838.666, 560.334), new Point(820, 569.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(820, 569.001), new Point(783.666, 578.668), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(783.666, 578.668), new Point(779.666, 580.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(783.333, 591.334), new Point(811.666, 586.001), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(849, 571.668), new Point(810.666, 581.668), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(818.333, 579.001), new Point(799.666, 586.334), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(820.666, 578.001), new Point(810.333, 586.334), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(836.666, 573.334), new Point(855.333, 558.668), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(867.333, 545.668), new Point(847.666, 571.001), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(864, 537.001), new Point(865.666, 546.668), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(862.666, 549.668), new Point(867, 559.334), brush, 7f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(769.333, 540.334), new Point(797, 524.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(794, 524.001), new Point(814.333, 518.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0xCD, 0xCC);
            sceneRenderer.DrawLine(new Point(823.333, 511.668), new Point(807, 519.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(633, 519.666), new Point(647.333, 550.666), brush, 25f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(648, 549.999), new Point(686.333, 555.666), brush, 25f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(657, 481.999), new Point(634, 519.332), brush, 25f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(699.667, 532.999), new Point(684.667, 545.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(697.667, 536.332), new Point(706.667, 542.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(702.667, 536.332), new Point(717.667, 565.999), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(717.333, 561.332), new Point(734, 588.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(731.667, 586.999), new Point(741, 622.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(453.333, 515.333), new Point(463.667, 501.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(463.333, 501), new Point(477.333, 491.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(461.667, 469), new Point(468, 480.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(467.333, 480.667), new Point(482.667, 489), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(476.667, 454), new Point(480.667, 463.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(477.667, 456.333), new Point(494.333, 464), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(480.333, 459), new Point(503.333, 476), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(490.667, 461), new Point(506, 474.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(480, 454.333), new Point(494.667, 463), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(478.333, 485), new Point(505.333, 475), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(494, 480), new Point(524.333, 471.667), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(473, 414.333), new Point(491, 433.667), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(480.667, 422.667), new Point(542.667, 455), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(502.333, 427), new Point(575.333, 454.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(514.333, 442.333), new Point(532.667, 481.667), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(485, 486.666), new Point(540, 502.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(503.667, 493), new Point(552, 524.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(536.667, 514.333), new Point(586.334, 586), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(555.667, 528.333), new Point(608, 641.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(557.333, 544.666), new Point(597, 625.666), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(594.334, 620.666), new Point(613, 649), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(611.334, 616), new Point(622.334, 660.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(459, 385), new Point(571.667, 429), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(442.667, 377), new Point(464.667, 378), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(565.667, 424.667), new Point(636.667, 466), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(582.334, 427), new Point(684.334, 491), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(605, 433.333), new Point(692.334, 480.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(573.667, 454.667), new Point(682, 497.333), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(522, 459), new Point(580.667, 471), brush, 40f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(463.333, 399.667), new Point(474, 416.333), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(461.667, 403), new Point(478, 413.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(466.667, 407), new Point(471.667, 418.333), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(649, 512.332), new Point(661.667, 506.665), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(661, 505.665), new Point(672, 514.332), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(669, 512.665), new Point(673, 522.332), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(648.667, 509.999), new Point(656, 499.665), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(654.667, 501.332), new Point(660, 492.999), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(652.334, 509.332), new Point(665.334, 500.665), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(653.334, 506.665), new Point(665.334, 495.332), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(664.334, 500.999), new Point(674.334, 511.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(669.334, 496.999), new Point(674, 519.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(631, 467.332), new Point(653, 477.999), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(607, 649.332), new Point(618.667, 658.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(619.334, 658.999), new Point(631, 663.665), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(854.334, 426.667), new Point(854.334, 444.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(850.334, 435.667), new Point(860.667, 473.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x75, 0x16, 0x23);
            sceneRenderer.DrawLine(new Point(864.667, 423), new Point(859.667, 440), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(485.333, 425), new Point(494.667, 425), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(492, 423.667), new Point(492.333, 432.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(492, 426.333), new Point(502.667, 426.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(498.667, 424.333), new Point(506.333, 423), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(504.667, 423), new Point(510.333, 425), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(508, 421), new Point(523, 424.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(521, 424), new Point(533, 430.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(529.333, 429), new Point(542.333, 432.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(523.333, 432.667), new Point(531.667, 434.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x8B, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(520, 429.667), new Point(550.333, 436), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(529.333, 493.667), new Point(588.667, 545.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(561, 503), new Point(588.667, 533.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(569.333, 526.333), new Point(616.334, 621.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(614, 571), new Point(636.334, 659), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(632.667, 593.667), new Point(649.667, 665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(644, 632), new Point(734, 598.333), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(571.667, 457), new Point(583, 456.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(567, 450.333), new Point(585.667, 459.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(473, 493), new Point(493.667, 484), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xA0, 0x1D, 0x29);
            sceneRenderer.DrawLine(new Point(488.667, 485), new Point(502, 485.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(509.25, 479), new Point(565.5, 465.25), brush, 5f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(599.75, 496);
                ellipse.RadiusX = 55.25f;
                ellipse.RadiusY = 21.5f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(600.875, 523);
                ellipse.RadiusX = 25.375f;
                ellipse.RadiusY = 12.75f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(572.5, 485.875);
                ellipse.RadiusX = 55f;
                ellipse.RadiusY = 21.875f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(498, 484.25), new Point(519.5, 475.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(503.25, 482.75), new Point(519.5, 490.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(516.75, 488.5), new Point(526, 502.25), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(524.5, 498.5), new Point(531.75, 501), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(582.75, 529.75), new Point(591.5, 540.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(591.5, 540.5), new Point(589.5, 548.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(589.25, 545.5), new Point(594, 564.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(597.75, 522.75), new Point(599.25, 561.25), brush, 18f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(725.75, 600);
                ellipse.RadiusX = 6.5f;
                ellipse.RadiusY = 4.75f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(721.875, 591.375);
                ellipse.RadiusX = 4.125f;
                ellipse.RadiusY = 3.125f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(629.875, 591.5);
                ellipse.RadiusX = 7.625f;
                ellipse.RadiusY = 7.25f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(613, 576.625);
                ellipse.RadiusX = 7.75f;
                ellipse.RadiusY = 11.125f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(713.375, 578.125);
                ellipse.RadiusX = 9.125f;
                ellipse.RadiusY = 12.875f;
                brush.Color = Color.FromArgb(0xFF, 0xBB, 0x27, 0x3E);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(715.75, 577), new Point(627.5, 584.25), brush, 30f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(703, 602), new Point(725, 597.5), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(707.75, 600.25), new Point(685.75, 593), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(665, 596), new Point(697.5, 595.75), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(451, 371), new Point(658.334, 335.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(434, 365), new Point(448.667, 378.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(439, 366.333), new Point(454.333, 374.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(457.667, 376.667), new Point(626.667, 436.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(626, 431), new Point(704.334, 475.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(861.25, 489.75), new Point(786, 491.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(843, 489.75), new Point(771.5, 522.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(754.75, 524), new Point(776.5, 522.75), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(762.5, 494.25), new Point(798.5, 501.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(785, 434), new Point(810.25, 468.5), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(777.5, 477), new Point(855.25, 481.25), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(682.666, 348.999), new Point(709.333, 356.666), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(709.333, 351.667), new Point(712.333, 361), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(708.667, 350.667), new Point(754.667, 371.333), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(714.667, 357), new Point(756.333, 374.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(753, 369.333), new Point(802.667, 407.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(759.333, 374), new Point(808, 404.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(807.667, 405), new Point(827.667, 442.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(803, 404), new Point(831.667, 411), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(817.333, 403.667), new Point(849.333, 422.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(872, 424.333), new Point(848.667, 428), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(876.667, 419.667), new Point(853.333, 422.333), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(827, 406.333), new Point(855.333, 419.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xCD, 0x4F, 0x61);
            sceneRenderer.DrawLine(new Point(840.667, 417.333), new Point(833.667, 424.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(460.666, 373.666), new Point(556, 384.334), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(487.666, 368.334), new Point(738.333, 369.334), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(483.334, 374), new Point(604.333, 419), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(573.334, 351), new Point(580.333, 400.666), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(632, 350), new Point(615.333, 422.666), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(699, 346), new Point(663.667, 418.334), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xB4, 0x27, 0x41);
            sceneRenderer.DrawLine(new Point(713.667, 397.334), new Point(751.667, 417.666), brush, 80f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(618.667, 418.666), new Point(699, 453.665), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(696.667, 479.667), new Point(761.667, 459.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(661.667, 439), new Point(686.667, 454), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(648.333, 420.333), new Point(757, 453.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(683.333, 456.667), new Point(733, 453.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(670.333, 377), new Point(646.333, 390.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(661, 376), new Point(750.667, 440.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(657, 390.667), new Point(801.667, 428), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(670, 409.667), new Point(722.667, 432.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(750.333, 380), new Point(800.667, 422.333), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(796.333, 419.667), new Point(833.333, 471.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(747.333, 422.667), new Point(782, 442.334), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(692, 381), new Point(758.667, 401.333), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(628.667, 378.667), new Point(645.667, 389.333), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(623, 379), new Point(645, 382.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(733.667, 378.333), new Point(748.667, 388), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(739.333, 382.333), new Point(751, 382), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(635.333, 438), new Point(660, 447.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(827.333, 419), new Point(833, 436.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(819.667, 441.667), new Point(838, 446), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(829, 443.334), new Point(836.667, 431), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(828.667, 422.333), new Point(843, 426.333), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(843, 425.667), new Point(842.667, 440), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(842.333, 438.334), new Point(848.333, 451.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(847.667, 448.667), new Point(845.667, 458.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(846.333, 456), new Point(849.667, 465.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(849.667, 466), new Point(856.333, 474), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(854, 471.334), new Point(831, 455.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(835.333, 424.667), new Point(840, 462), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xCF, 0x37, 0x56);
            sceneRenderer.DrawLine(new Point(818.667, 442.667), new Point(844.667, 466), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(552, 382.001), new Point(582.334, 389.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(549.333, 369.667), new Point(559, 383.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(554.667, 372.334), new Point(573.667, 381.334), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(583.667, 353.334), new Point(603.334, 354.001), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(578, 349.001), new Point(631.667, 348.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(631, 349.334), new Point(639.334, 356.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(635.334, 349.334), new Point(638.334, 361.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(634.334, 348.667), new Point(653.667, 352.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(646.334, 351.001), new Point(669.334, 357.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(629.667, 344.001), new Point(655.667, 348.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(631, 548.334), new Point(649.667, 556.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(646.334, 555.334), new Point(661.334, 556.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(660.334, 556.668), new Point(665, 561.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(668.334, 560.001), new Point(695, 560.668), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(693.334, 541.668), new Point(713, 561.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(670.334, 559.668), new Point(652.667, 566.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(672.334, 551.668), new Point(685.667, 543.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(682.667, 545.334), new Point(696.334, 550.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(659.334, 342.001), new Point(647.667, 344.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(656.667, 334.001), new Point(659.667, 339.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(659.667, 339.001), new Point(669.334, 343.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(665.667, 334.667), new Point(671, 343.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(689, 474.001), new Point(669.334, 484.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(687.334, 472.334), new Point(667, 480.668), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(671.334, 481.668), new Point(661.334, 496.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(679.334, 479.001), new Point(680.334, 490.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(680.667, 475.668), new Point(665, 463.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xAD, 0x5D, 0x6D);
            sceneRenderer.DrawLine(new Point(566.333, 537.001), new Point(574.333, 547.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(710.667, 358.667), new Point(737.667, 369.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(735, 368.334), new Point(752, 377.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(752.334, 377.001), new Point(765, 385.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(650.334, 392.334), new Point(675, 402.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(658, 394.667), new Point(677, 399.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(674.334, 400.667), new Point(693.334, 414.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(688, 409.334), new Point(701.334, 418.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(698.334, 415.334), new Point(705, 428.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(600.334, 400.667), new Point(621.334, 407.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(611, 396.667), new Point(613.667, 406.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(611.667, 399.667), new Point(641.334, 411.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(629, 408.001), new Point(653, 419.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(640.667, 410.334), new Point(660.334, 419.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(574, 411.334), new Point(588.334, 418.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(578, 413.667), new Point(601.334, 413.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(507.667, 481.334), new Point(519.667, 485.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(525.333, 477), new Point(511.667, 482), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(453.667, 377.667), new Point(476.333, 382.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE1, 0x93, 0xA1);
            sceneRenderer.DrawLine(new Point(466.333, 378.333), new Point(488, 383.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(613.334, 354.001), new Point(602.334, 365.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(605, 361.334), new Point(579, 362.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(565.333, 357.334), new Point(597.667, 357.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(582.667, 374.334), new Point(569.333, 381.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(594, 389.667), new Point(620.334, 388.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(610.667, 381.334), new Point(625.334, 389.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(601, 390.001), new Point(609.334, 396.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(652.334, 384.334), new Point(663, 376.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(662.334, 376.334), new Point(676.334, 376.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(673.667, 371.334), new Point(681.667, 382.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(680.667, 376.667), new Point(667.334, 383.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(679.667, 381.334), new Point(669, 384.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(676, 377.001), new Point(691, 379.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(690.667, 377.001), new Point(700.667, 386.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(705, 379.667), new Point(691.334, 392.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(675.667, 388.667), new Point(693.334, 391.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(670.667, 385.334), new Point(662.667, 386.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(699, 384.334), new Point(722, 390.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(729.667, 386.667), new Point(709, 386.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(714.334, 389.334), new Point(741.334, 400.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(721.334, 390.001), new Point(749.667, 394.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(747.334, 388.667), new Point(735.334, 403.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(752.334, 399.334), new Point(768, 409.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(817.334, 415.001), new Point(828.667, 418.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(830, 413.667), new Point(831.667, 422.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(826.334, 411.001), new Point(829.667, 417.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(676, 546.668), new Point(694.667, 556.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(681, 554.668), new Point(701.334, 554.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(688.334, 556.334), new Point(712.667, 566.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(718.667, 573.668), new Point(701, 576.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(705.667, 559.668), new Point(697.667, 557.668), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(745.334, 407.001), new Point(762, 416.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xEC, 0xC0, 0xCD);
            sceneRenderer.DrawLine(new Point(753.334, 407.334), new Point(769, 414.334), brush, 6f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(608.167, 574.5);
                ellipse.RadiusX = 7.833f;
                ellipse.RadiusY = 8.834f;
                brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(880.667, 438.334);
                ellipse.RadiusX = 15.667f;
                ellipse.RadiusY = 20.333f;
                brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(550.833, 493.334);
                ellipse.RadiusX = 5.5f;
                ellipse.RadiusY = 4.667f;
                brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(869, 415), new Point(886.334, 420.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(553.667, 495.001), new Point(567.333, 501.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(567.667, 501.334), new Point(577.667, 496.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(582.334, 492.334), new Point(559.333, 497.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(569.333, 490.001), new Point(548.333, 488.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(569, 489.667), new Point(546.333, 496.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(586.334, 496.667), new Point(563.667, 499.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(596.667, 502.334), new Point(609.334, 501.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(609.334, 500.667), new Point(623.667, 503.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(603, 494.334), new Point(611.667, 501.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(648.334, 501.667), new Point(637.667, 505.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(605.334, 497.667), new Point(625, 501.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(585, 558.001), new Point(601.667, 575.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(588.334, 558.001), new Point(599.334, 576.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(592, 540.667), new Point(596.334, 550.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(596.334, 551.334), new Point(593.334, 553.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(594.667, 550.001), new Point(595.667, 557.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(595.667, 557.334), new Point(594, 565.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(593, 543.001), new Point(605.334, 548.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(605, 547.667), new Point(606.667, 543.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(606.334, 542.667), new Point(603.667, 542.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(603.334, 542.334), new Point(606.334, 530.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(598.334, 531.001), new Point(603.334, 530.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(603, 529.334), new Point(605, 532.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(597.667, 529.334), new Point(607, 518.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(606.667, 518.667), new Point(603.334, 516.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(606.334, 512.667), new Point(607.334, 518.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(608, 513.667), new Point(634, 526.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(617, 513.001), new Point(643.667, 500.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(614.334, 506.334), new Point(660.667, 513.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(630.334, 505.001), new Point(661.334, 515.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(622.334, 546.001), new Point(637, 558.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(636.667, 558.001), new Point(636, 552.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(642.334, 548.667), new Point(645.334, 561.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(638.334, 551.001), new Point(646.667, 560.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(645.334, 561.001), new Point(632.667, 561.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(645.334, 561.334), new Point(627.334, 555.001), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(618.334, 497.667), new Point(635.667, 498.667), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(619, 494.334), new Point(637, 498.334), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(624.334, 501.001), new Point(636, 522.001), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(602.667, 522.334), new Point(630, 532.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(594.334, 560.667), new Point(627, 555.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(632.334, 539.667), new Point(603, 540.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(619.334, 577.667), new Point(638, 563.334), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(594.334, 546.334), new Point(633.667, 560.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(598.667, 570.334), new Point(645.667, 569.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(643.334, 509.001), new Point(622.334, 536.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(786.334, 427.334), new Point(782, 440.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xE9, 0xB8, 0xC8);
            sceneRenderer.DrawLine(new Point(785.334, 430.667), new Point(793, 430.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(585, 415.667), new Point(639.667, 439.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(639.334, 439.667), new Point(640.334, 434.001), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(640.334, 434.667), new Point(657.667, 430.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(657.334, 430.334), new Point(654.667, 423.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(655, 424.334), new Point(623, 408.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(623.334, 408.334), new Point(620, 405), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(620, 405), new Point(612, 406), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(612.334, 406), new Point(612.334, 410.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(612.667, 410.667), new Point(586.667, 415.667), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(635.667, 414.667), new Point(620, 419.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(622, 419.667), new Point(623.334, 431), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(621.667, 425), new Point(646, 422), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(642.667, 418.667), new Point(623.667, 430.334), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(641, 434.667), new Point(596.667, 414.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(654.334, 424.667), new Point(630.667, 430.334), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(623.334, 408), new Point(611.334, 421), brush, 18f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(591.667, 416), new Point(601.334, 418.667), brush, 8f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(692.667, 508.5);
                ellipse.RadiusX = 20f;
                ellipse.RadiusY = 25.834f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(784, 457.168);
                ellipse.RadiusX = 11f;
                ellipse.RadiusY = 11.166f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(838.667, 478.5);
                ellipse.RadiusX = 7.333f;
                ellipse.RadiusY = 8.834f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(847.5, 472.668);
                ellipse.RadiusX = 5.833f;
                ellipse.RadiusY = 3.667f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(825.5, 495.334);
                ellipse.RadiusX = 4.5f;
                ellipse.RadiusY = 4f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(824.167, 482.668);
                ellipse.RadiusX = 7.167f;
                ellipse.RadiusY = 9.666f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(745.5, 502.5);
                ellipse.RadiusX = 22.167f;
                ellipse.RadiusY = 16.834f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(770.167, 484);
                ellipse.RadiusX = 18.833f;
                ellipse.RadiusY = 12.334f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(808, 457.667);
                ellipse.RadiusX = 8.333f;
                ellipse.RadiusY = 6f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(751.333, 467.834);
                ellipse.RadiusX = 12.333f;
                ellipse.RadiusY = 13.167f;
                brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(781, 509.667), new Point(749.667, 506.667), brush, 20f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(745.334, 516.001), new Point(775.667, 516.001), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(712.334, 449.334), new Point(746.667, 474.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(725.334, 452.334), new Point(754.667, 489.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(743.334, 451.001), new Point(785.667, 479.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(751.334, 433.334), new Point(786.334, 475.667), brush, 16f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(734, 426.667), new Point(755, 431.334), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(768, 445.001), new Point(783, 448.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(790, 461.334), new Point(796, 469.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(791.334, 445.334), new Point(804.334, 455.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(812.334, 460.334), new Point(822, 480.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(815, 458.667), new Point(832.334, 475.001), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(836.334, 466.001), new Point(847, 471.667), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(807, 469.001), new Point(823.667, 496.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(788, 494.334), new Point(788, 502.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(788.334, 502.667), new Point(785, 508.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(786.667, 507.667), new Point(776.334, 512.001), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(787.667, 489.334), new Point(792, 490.667), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(789, 512.667), new Point(769.334, 527.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(777, 512.667), new Point(792, 511.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(716.667, 501.001), new Point(748, 528.001), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(741.334, 522.667), new Point(772.334, 525.667), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(730.667, 473.667), new Point(683, 487.001), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(726.667, 475.667), new Point(748.667, 490.001), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(687.334, 476.334), new Point(731.334, 493.001), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(720, 480.001), new Point(704, 520.667), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(756.334, 479.001), new Point(705.667, 499.001), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(878, 461.334), new Point(862.667, 482.334), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(861.334, 477.001), new Point(865.667, 499.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(876.334, 472.001), new Point(876, 479.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(878.667, 478.667), new Point(867, 495.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(873.667, 476.001), new Point(864.334, 490.667), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(708.667, 445.334), new Point(712.667, 448.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(706, 440.334), new Point(710, 445.667), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(712.667, 437.334), new Point(711.334, 442.334), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xF2, 0xD1, 0xDD);
            sceneRenderer.DrawLine(new Point(710.667, 429.667), new Point(716.334, 440.001), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6A, 0xA0, 0xD5);
            sceneRenderer.DrawLine(new Point(775, 602.75), new Point(776.75, 635.75), brush, 14f);

            brush.Color = Color.FromArgb(0xFF, 0xC7, 0xC5, 0xC5);
            sceneRenderer.DrawLine(new Point(869.75, 554.75), new Point(871.25, 582.5), brush, 2f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(654.5, 689), new Point(749.5, 668.75), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(729.25, 661), new Point(674, 678), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(768.25, 676.5), new Point(850.5, 643.75), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(849.5, 644.75), new Point(868.5, 629.25), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(867.75, 630), new Point(895, 601.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(897.75, 596.75), new Point(895.75, 603.75), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(752, 682.25), new Point(729.25, 694), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(730, 692.75), new Point(697, 700.75), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(698, 702), new Point(665.75, 706.5), brush, 8f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(664.25, 705.125);
                ellipse.RadiusX = 9f;
                ellipse.RadiusY = 3.625f;
                brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(655.125, 690);
                ellipse.RadiusX = 5.625f;
                ellipse.RadiusY = 3.25f;
                brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0x57, 0x16, 0x1F);
            sceneRenderer.DrawLine(new Point(725.75, 664), new Point(739, 668), brush, 4f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(770.333, 667.998), new Point(855, 636.665), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(898.667, 592.332), new Point(879.333, 610.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(879.333, 610.332), new Point(861.333, 629.998), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(861.333, 629.998), new Point(849.333, 637.332), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(770.333, 663.665), new Point(858, 630.998), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(874.333, 612.998), new Point(847.667, 637.332), brush, 5f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(886.167, 588.498);
                ellipse.RadiusX = 9.167f;
                ellipse.RadiusY = 6.166f;
                brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(890, 589.332), new Point(865, 615.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(884.333, 586.998), new Point(871.333, 586.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(877.333, 586.665), new Point(844.667, 621.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(865.667, 614.998), new Point(850, 626.998), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(881.333, 588.665), new Point(852.333, 622.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(851.667, 626.665), new Point(789.333, 652.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(769, 656.998), new Point(792.667, 651.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(849.333, 622.998), new Point(788.667, 643.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(792.667, 642.665), new Point(769.333, 647.665), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xE7, 0xE2);
            sceneRenderer.DrawLine(new Point(769.667, 642.998), new Point(777.667, 644.332), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(666.667, 697.332), new Point(705, 691.665), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(703.5, 691.25), new Point(731.25, 685), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0x44, 0x45, 0x51);
            sceneRenderer.DrawLine(new Point(728.75, 684.25), new Point(754.5, 674.75), brush, 12f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(772.5, 641.5), new Point(840, 622), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(770.5, 638), new Point(841.5, 621.5), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(848, 614.5), new Point(835, 623), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(871.5, 581.5), new Point(848, 612), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(432.5, 561), new Point(359.5, 524), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(279.5, 473.5), new Point(300.5, 487), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0xA5, 0x9D, 0xA0);
            sceneRenderer.DrawLine(new Point(611, 659), new Point(640, 670), brush, 3f);

            brush.Color = Color.FromArgb(0xFF, 0x2D, 0x2B, 0x2A);
            sceneRenderer.DrawLine(new Point(907, 535.667), new Point(908.334, 600.334), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(900.5, 509), new Point(892, 544), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(893.5, 543), new Point(879, 565), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(879, 565), new Point(869, 571), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(871, 538.5), new Point(871.5, 567), brush, 6f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(871.5, 562.5), new Point(888, 547.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(879.5, 479.5), new Point(868, 502.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(896.5, 488.5), new Point(889.5, 511), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(899.5, 487.5), new Point(898, 511.5), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(902.5, 504), new Point(903.5, 536), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0xAA, 0x5C, 0x68);
            sceneRenderer.DrawLine(new Point(903.5, 523), new Point(892.5, 544), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(361.5, 221), new Point(393.5, 238), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x68, 0x6A, 0x6D);
            sceneRenderer.DrawLine(new Point(388, 235.5), new Point(403.5, 248), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(600, 273), new Point(595.5, 284), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(597, 281.5), new Point(618, 280), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(598.5, 276), new Point(622, 284.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(617.5, 280.5), new Point(615, 299), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(615.5, 298.5), new Point(626.5, 299), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(626.5, 299), new Point(627, 305), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(627, 305.5), new Point(634.5, 302), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(633, 301.5), new Point(640.5, 298), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(639.5, 298), new Point(621.5, 263.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(621.5, 263), new Point(609, 246.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(609, 246), new Point(601, 241), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(601, 240), new Point(409, 259), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(414.5, 259), new Point(404.5, 259.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(404, 259.5), new Point(407, 278), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(405.5, 269.5), new Point(417, 304.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(413, 299), new Point(430, 313), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(416.5, 283.5), new Point(419.5, 302.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(408.5, 275), new Point(422.5, 283.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(417.5, 280), new Point(427.5, 269), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(424.5, 266.5), new Point(430, 273.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(428.5, 272), new Point(421, 284.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(432, 276), new Point(417.5, 285.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(421.5, 281.5), new Point(426, 295.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(426, 295.5), new Point(415, 276), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(440.5, 308), new Point(444.5, 311.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(444, 316), new Point(461.5, 298), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(459, 298), new Point(467, 304.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(468, 303.5), new Point(465, 305.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(532.5, 317.5), new Point(546.5, 304), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(565, 299), new Point(539, 311.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(607, 303), new Point(622.5, 295.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(621, 298), new Point(632, 303.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(626.5, 308.5), new Point(641.5, 298), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(612.5, 251), new Point(615, 268.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(615, 269), new Point(628, 276), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(622, 270), new Point(617.5, 279.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(614.5, 259), new Point(624.5, 274), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(622, 275), new Point(633.5, 302), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(616.5, 278), new Point(622.5, 298), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x6B, 0x65, 0x71);
            sceneRenderer.DrawLine(new Point(415, 276), new Point(421, 314.5), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x9F, 0xA8);
            sceneRenderer.DrawLine(new Point(427, 282.5), new Point(446.5, 308), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x9F, 0xA8);
            sceneRenderer.DrawLine(new Point(434.5, 277), new Point(445.5, 290), brush, 10f);

            brush.Color = Color.FromArgb(0xFF, 0x99, 0x9F, 0xA8);
            sceneRenderer.DrawLine(new Point(445, 280.5), new Point(454.5, 291.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(444, 336.5), new Point(608.5, 312.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(606.5, 302.5), new Point(589, 316), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(592, 314.5), new Point(583.5, 325.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(530, 314.5), new Point(515.5, 324.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(517, 322), new Point(506.5, 337), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(422, 314), new Point(427, 328.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(438, 317.5), new Point(426.5, 326), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(427, 324.5), new Point(433.5, 333.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(433.5, 334), new Point(444.5, 338), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(440.5, 329), new Point(453.5, 338), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(446, 337.5), new Point(473.5, 331.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(601.5, 313), new Point(616.5, 310.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(616.5, 310.5), new Point(623.5, 310.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(623, 301.5), new Point(623, 309), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(635.5, 307), new Point(647.5, 300), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(424, 315), new Point(433.5, 322.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(436.5, 336), new Point(432, 319), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(424, 317.5), new Point(433.5, 329.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(584, 284), new Point(588, 269.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(581, 268.5), new Point(584.5, 278), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(584, 267.5), new Point(584, 276), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(601, 237.5), new Point(610.5, 242.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(611, 241), new Point(625, 264), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(624.5, 264), new Point(644.5, 300.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(606, 237), new Point(618, 244.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(615, 233.5), new Point(618.5, 251.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(613, 234), new Point(609.5, 249), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(400, 257.5), new Point(461.5, 251.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x92, 0x88, 0x92);
            sceneRenderer.DrawLine(new Point(399.5, 256), new Point(403, 271), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC5, 0x7E, 0x94);
            sceneRenderer.DrawLine(new Point(459, 342), new Point(431.5, 347), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC5, 0x7E, 0x94);
            sceneRenderer.DrawLine(new Point(436.5, 359.5), new Point(428, 331), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xC5, 0x7E, 0x94);
            sceneRenderer.DrawLine(new Point(430, 338), new Point(443.5, 344.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0x41, 0x56);
            sceneRenderer.DrawLine(new Point(440.5, 360), new Point(622, 326), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0x41, 0x56);
            sceneRenderer.DrawLine(new Point(644, 330.5), new Point(443.5, 365.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xB7, 0x41, 0x56);
            sceneRenderer.DrawLine(new Point(646, 322), new Point(435, 358.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x46, 0x1D, 0x20);
            sceneRenderer.DrawLine(new Point(416, 307), new Point(434, 366), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xD4, 0xDC);
            sceneRenderer.DrawLine(new Point(459, 342.5), new Point(504, 334.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xE6, 0xD4, 0xDC);
            sceneRenderer.DrawLine(new Point(514.5, 335), new Point(581, 324.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xDF, 0xC2, 0xCF);
            sceneRenderer.DrawLine(new Point(593.5, 322), new Point(622.5, 315.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC6, 0x41, 0x61);
            sceneRenderer.DrawLine(new Point(623.5, 314), new Point(654.5, 313.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xC6, 0x41, 0x61);
            sceneRenderer.DrawLine(new Point(650.5, 304.5), new Point(632.5, 316.5), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(709.667, 510.334), new Point(686, 510.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(867.334, 442.667), new Point(887.334, 448.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(882, 446), new Point(883, 461.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(869.667, 439.334), new Point(868.334, 451.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(868.334, 452), new Point(871, 459.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(870.667, 459.334), new Point(882.334, 460.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(871, 445), new Point(879, 456.334), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(867, 448), new Point(872, 462.667), brush, 8f);

            brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
            sceneRenderer.DrawLine(new Point(685.334, 506.334), new Point(677.667, 522.334), brush, 8f);

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(692.333, 521.834);
                ellipse.RadiusX = 15.667f;
                ellipse.RadiusY = 13.166f;
                brush.Color = Color.FromArgb(0xFF, 0xF8, 0xF9, 0xFA);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(706.5, 498.5);
                ellipse.RadiusX = 7f;
                ellipse.RadiusY = 9f;
                brush.Color = Color.FromArgb(0xFF, 0xBD, 0xB5, 0xB9);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            {
                CanvasEllipse ellipse = new CanvasEllipse();
                ellipse.Point = new Point(695, 497.25);
                ellipse.RadiusX = 13f;
                ellipse.RadiusY = 5.25f;
                brush.Color = Color.FromArgb(0xFF, 0xBD, 0xB5, 0xB9);
                sceneRenderer.FillEllipse(ellipse, brush);
            }

            brush.Color = Color.FromArgb(0xFF, 0xBD, 0xB5, 0xB9);
            sceneRenderer.DrawLine(new Point(685.5, 499), new Point(706, 505), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0xBD, 0xB5, 0xB9);
            sceneRenderer.DrawLine(new Point(708, 491.5), new Point(690, 495.5), brush, 5f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x47, 0x44);
            sceneRenderer.DrawLine(new Point(237, 297), new Point(232, 343), brush, 9f);

            brush.Color = Color.FromArgb(0xFF, 0x56, 0x47, 0x44);
            sceneRenderer.DrawLine(new Point(235, 301), new Point(257, 251), brush, 9f);
        }
    }
}