let outputList = document.querySelector(".output-list");
let datas = [];
window.onload = function () {
    fetchWord();
};

async function fetchWord(){
    datas = [];
    outputList.innerHTML = "";
    const url = "https://localhost:44321/api/Word/";
    const getWordList = await fetch(url, {
        method: "GET", // or 'PUT'
    })
        .then((response) => response.json())
        .then((data) => {
            data.forEach((item) => {
                datas.push(item);
            });
            renderDatas(datas);
        })
        .catch((error) => {
            console.error("Error:", error);
        });
};
const createOutputItem = (data) => {
    let examplesHTML = document.createElement("ul");
    examplesHTML.className = "word-example-list";
    examplesHTML.innerHTML = `
        <li class="word-example-item">
            <p>
            ${data.ThongTinThem}
    </p>
        </li>`;
    var wordListItem = document.createElement("li");
    wordListItem.className = "output-item container px-3 py-2 my-2";
    wordListItem.innerHTML = `
  <h6 class="word-type">${data.LoaiTu}</h6>
  <div class="word-meaning">${data.TiengViet}</div>
  <h6>Ví dụ:</h6>`;

    var delWordButton = document.createElement("button");
    delWordButton.className = "btn btn-submit";
    delWordButton.innerHTML = `Xoá`;
    delWordButton.addEventListener(
        "mouseup",
        function () {
            delWord(data);
        },
        false
    );

    var wordAction = document.createElement("div");
    wordAction.className = "word-action w-100 text-end";
    wordAction.appendChild(delWordButton);

    wordListItem.appendChild(examplesHTML);
    wordListItem.appendChild(wordAction);

    outputList.appendChild(wordListItem);
};

async function delWord(data){
    let url = `https://localhost:44321/api/Word/?id=${data.id}`;
    const deleteWord = await fetch(url, {
        method: "DELETE",
    })
        .then((res) => res.text()) // or res.json()
        .then((res) => console.log(res));
    fetchWord();
};
const renderDatas = (datas) => {
    datas.forEach((data) => {
        createOutputItem(data);
    });
};
