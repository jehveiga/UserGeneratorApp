function CarregaFuncaoPrint() {
    const btnGenerate = document.querySelector("#btn_generate_Pdf");

    btnGenerate.addEventListener("click", () => {

        // Conteúdo do PDF

        let container = document.getElementById("divTabela").cloneNode(true);

        elementosUltimacoluna = container.querySelectorAll(".btn-print-hide");

        if (elementosUltimacoluna.length > 0) {
            elementosUltimacoluna.forEach(e => {
                e.style.display = "none";
            });
        }

        const content = container.innerHTML

        // configuração do arquivo final de PDF
        let estilo = "<style>";
        estilo += "table {width: 100%; font: 25px; Calibri;}";
        estilo += "table, th, td {border: solid 2px #888; border-collapse: collapse;";
        estilo += "padding: 4px 8px;text-align: center;";
        estilo += "</style>";

        const win = window.open('', '', 'height=700, width=700');

        win.document.write('<html><head>');
        win.document.write('<title><Export PDF</title>');
        win.document.write(estilo);
        win.document.write('</head><body>');
        win.document.write(content);
        win.document.write('</body></html>');

        //Gerar e baixar para PDF
        win.print()


    })
}