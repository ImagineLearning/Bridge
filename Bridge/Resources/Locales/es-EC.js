﻿Bridge.merge(new Bridge.CultureInfo("es-EC", true), {
    englishName: "Spanish (Ecuador)",
    nativeName: "español (Ecuador)",

    numberFormat: Bridge.merge(new Bridge.NumberFormatInfo(), {
        naNSymbol: "NeuN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-Infinito",
        positiveInfinitySymbol: "Infinito",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ",",
        percentGroupSeparator: ".",
        percentPositivePattern: 0,
        percentNegativePattern: 0,
        currencySymbol: "$",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ",",
        currencyGroupSeparator: ".",
        currencyNegativePattern: 14,
        currencyPositivePattern: 2,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ",",
        numberGroupSeparator: ".",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new Bridge.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["dom","lun","mar","mié","jue","vie","sáb"],
        abbreviatedMonthGenitiveNames: ["ene","feb","mar","abr","may","jun","jul","ago","sep","oct","nov","dic",""],
        abbreviatedMonthNames: ["ene","feb","mar","abr","may","jun","jul","ago","sep","oct","nov","dic",""],
        amDesignator: "",
        dateSeparator: "/",
        dayNames: ["domingo","lunes","martes","miércoles","jueves","viernes","sábado"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "dddd, dd' de 'MMMM' de 'yyyy H:mm:ss",
        longDatePattern: "dddd, dd' de 'MMMM' de 'yyyy",
        longTimePattern: "H:mm:ss",
        monthDayPattern: "d' de 'MMMM",
        monthGenitiveNames: ["enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre",""],
        monthNames: ["enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre",""],
        pmDesignator: "",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "dd/MM/yyyy",
        shortestDayNames: ["do","lu","ma","mi","ju","vi","sá"],
        shortTimePattern: "H:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM' de 'yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
