const searchWord = () => {
    let outputList = document.querySelector(".output-list");
    outputList.innerHTML = "";
    let tiengAnh = document.querySelector("#tiengAnhTxt").value.toLowerCase();
    const url =
        `https://dictionary-api-five.vercel.app/api/v1/entries/vi/` + tiengAnh;

    const getData = fetch(url)
        .then((response) => response.json())
        .then((wordsOutput) => {
            let resHTML = "";
            wordsOutput.forEach((word) => {
                const data = {
                    ngayThem: new Date().toLocaleDateString(),
                    tiengAnh: tiengAnh,
                    tiengViet: word.translate,
                    thongTinThem: word.meanings[0].definitions[0].examples,
                    loaiTu: word.type,
                }
                
                let examples = [];
                word.meanings.forEach((meaning) => {
                    examples.push(meaning.definitions[0].examples);
                });
                let examplesHTML = "";
                for (var i = 0; i < examples.length; i++) {
                    examplesHTML.innerHTML +=
                        `<li class="word-example-item"><p>` + examples[i] + `</p></li>`;
                }
                var addWordButton = document.createElement("button");
                addWordButton.innerHTML = '<button class="btn btn-submit">Lưu từ</button>';

                var html = `
                      <li class="output-item container px-3 py-2 my-2">
                        <h6 class="word-type">${word.type}</h6>
                        <div class="word-meaning">${word.translate}</div>
                        <h6>Ví dụ:</h6>
                        <ul class="word-example-list"> 
                              ${examplesHTML}
                        </ul>
                        <div class="word-action w-100 text-end">
                              ${addWordButton.innerHTML}
                        </div>
                      </li>
                    `;            
                resHTML += html;
                addWordButton.addEventListener("click", addWord(data));
            });
            outputList.innerHTML += (resHTML);
        });
};
let buttonSearch = document.querySelector("#btn-search");
buttonSearch.addEventListener("click", searchWord);

const addWord = (data) => {
    let url = `https://localhost:44321/api/Word/?ngayThem=${data.ngayThem}&tiengAnh=${data.tiengAnh}&tiengViet=${data.tiengViet}&thongTinThem=${data.thongTinThem}&loaiTu=${data.loaiTu}`;
    const pushWord = fetch(url, {
        method: 'POST', // or 'PUT'
        })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}
