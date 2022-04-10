const searchWord = () => {
    let tiengAnh = document.querySelector("#tiengAnhTxt").value.toLowerCase();
    const url =
        `https://dictionary-api-five.vercel.app/api/v1/entries/vi/` + tiengAnh;

    const getData = fetch(url)
        .then((response) => response.json())
        .then((wordsOutput) => {
            let resHTML = "";
            wordsOutput.forEach((word) => {
                let examples = [];
                console.log(word);
                word.meanings.forEach((meaning) => {
                    examples.push(meaning.definitions[0].examples);
                });
                let examplesHTML = "";
                for (var i = 0; i < examples.length; i++) {
                    examplesHTML +=
                        `<li class="word-example-item"><p>` + examples[i] + `</p></li>`;
                }
                var html = `
                  <li class="output-item container px-3 py-2 my-2">
                    <h6 class="word-type">${word.type}</h6>
                    <div class="word-meaning">${word.translate}</div>
                    <h6>Ví dụ:</h6>
                    <ul class="word-example-list"> 
                          ${examplesHTML}
                    </ul>
                    <div class="word-action w-100 text-end">
                      <button class="btn btn-submit">Lưu từ</button>
                    </div>
                  </li>
          `;
                resHTML += html;
            });

            outputList = document.querySelector(".output-list");
            outputList.innerHTML = resHTML;
        });
};
//   const timeElapsed = Date.now();
//   const today = new Date(timeElapsed);
//   today.toLocaleDateString();
let buttonSearch = document.querySelector("#btn-search");
buttonSearch.addEventListener("click", searchWord);
