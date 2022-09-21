function myFaktur() {
    var divContents = document.getElementById("myFaktur").innerHTML;
    var a = window.open('', '', 'height=500, width=500');
    a.document.write('<html>');
    a.document.write('<style type = "text/css">');
    var table_style = document.getElementById("table_style").innerHTML;
    a.document.write(table_style);
    a.document.write('</style>');
    a.document.write('</head><body >');
    a.document.write('<body > <br>');
    a.document.write(divContents);
    a.document.write('</body></html>');
    a.document.close();
    a.focus();
    a.print();
    setTimeout(a.close, 500);
}

