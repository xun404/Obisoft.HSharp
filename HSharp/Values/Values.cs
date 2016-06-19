﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obisoft.HSharp
{
    public enum DocumentOptions
    {
        Empty,
        BasicHTML
    }
    static class Values
    {
        public static string HTMLMatch = @"<(?'TN'\w+)\s*(?'TP'[^<>]*)>(?'TC'[\d\D]*?(((?'Open'<\k'TN'[^>]*>)[\d\D]*?)+((?'-Open'</\k'TN'[^>]*>)[\d\D]*?)+)*(?(Open)(?!)))</\k'TN'>|<(?'TN'\w+)\b*(?'TP'[^<>]*)/\s*>";
        public static string PropertiesMatch = $@"\s*([-\w]+)={"\"([^\"]*?)\""}\s*";
        public static string NoneHTMLMatch = $@"(?'RS'\w+)";
    }
}