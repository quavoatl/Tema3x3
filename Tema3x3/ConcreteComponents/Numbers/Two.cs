﻿using System;
using Tema3x3.BaseComponents;
using Tema3x3.Helpers;

namespace Tema3x3.ConcreteComponents.Numbers
{
    public sealed class Two : RepresentationBase
    {
        private static RepresentationBase Instance;

        public static RepresentationBase GetInstance()
        {
            if (Instance == null)
            {
                return new Two();
            }

            return Instance;
        }

        private Two() { }

        private string _numberRepresentation_Head = Constants.DOT + Constants.UNDERSCORE + Constants.DOT + " ";
        private string _numberRepresentation_Body = Constants.DOT + Constants.UNDERSCORE + Constants.PIPE + " ";
        private string _numberRepresentation_Footer = Constants.PIPE + Constants.UNDERSCORE + Constants.DOT + " ";

        public override string Head { get => _numberRepresentation_Head; set => _numberRepresentation_Head = value; }
        public override string Body { get => _numberRepresentation_Body; set => _numberRepresentation_Body = value; }
        public override string Footer { get => _numberRepresentation_Footer; set => _numberRepresentation_Footer = value; }

    }
}