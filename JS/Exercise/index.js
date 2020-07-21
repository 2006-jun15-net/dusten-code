'use strict';

const loadButton = document.getElementById("load-button");
const unloadButton = document.getElementById("unload-button");
const videoDiv = document.getElementById("videos");
const videoButtonsList = document.getElementById("video-buttons");
const loadedVideoDiv = document.getElementById("loaded-video");
const errorMessageDiv = document.getElementById("error-message");

errorMessageDiv.style.display = "none";

function AddData(data) {

  let entry = document.createElement('li');
  let dropdown = document.createElement('div');
  let dropdownContent = document.createElement('div');
  let title = document.createElement('span');
  let button = document.createElement('button');
  let date = document.createElement('p');

  let dropdownId = data.title.toLowerCase().replace(/\s+/g, '');

  dropdown.classList.add('dropdown');
  dropdown.id = dropdownId;

  dropdownContent.classList.add('dropdown-content');

  let dateFormatted = new Date(data.date);

  title.innerHTML = data.title;
  date.innerHTML = `Date: ${dateFormatted.getMonth() + 1}/${dateFormatted.getDate()}/${dateFormatted.getFullYear()}`;
  button.innerHTML = `Load "${data.title}"`;

  button.addEventListener('click', () => {
    loadedVideoDiv.innerHTML = data.embed;

    let loadeds = document.getElementsByClassName('loaded');

    for (index in loadeds) {
      loadeds[index].classList.remove('loaded');
    }
    document.getElementById(dropDownId).classList.add('loaded');
  });

  dropdownContent.appendChild(button);
  dropdownContent.appendChild(date);

  dropdown.appendChild(title);
  dropdown.appendChild(dropdownContent);

  entry.appendChild(dropdown);

  videoDiv.appendChild(entry);
}

unloadButton.addEventListener("click", () => {
  loadedVideoDiv.innerHTML = "No video loaded";
});

loadButton.addEventListener("click", () => {

  fetch("https://www.scorebat.com/video-api/v1/",
    {
      method: "GET",
      headers: { "Accept": "application/json" }
    })
    .then(response => response.json())
    .then(videoData => {
      for (let index in videoData) {
        AddData(videoData[index]);
      }
    })
    .catch(error => {
      console.log(error);
      errorMessageDiv.style.display = "block";
      errorMessageDiv.innerHTML = error.toString();
    });
});

function getVideoData(onSuccess, onError) {

  errorMessageDiv.style.display = "none";

  const xhr = new XMLHttpRequest();

  xhr.addEventListener("readystatechange", () => {
    console.log(`ready state: ${xhr.readyState}`);

    if (xhr.readyState === 4) {

      if (xhr.status === 200) {
        onSuccess(xhr.response);
      } else {
        onError(xhr.status);
      }
    }
  });

  xhr.open("GET", "https://www.scorebat.com/video-api/v1/");

  xhr.responseType = "json";
  xhr.setRequestHeader("Accept", "application/json");

  xhr.send();
}
