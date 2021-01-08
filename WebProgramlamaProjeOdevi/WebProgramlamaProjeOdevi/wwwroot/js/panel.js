document.getElementById('getPosts').addEventListener('click', getPosts);
document.getElementById('addPost').addEventListener('submit', addPost);

function getPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
        .then((response) => response.json())
        .then((data) => {
            let posts = '<h2 class="mb-4">Random Posts</h2>';
            data.forEach((post) => {
                posts += `
      <div class="card card-body mb-3">
        <h3>${post.title}</h3>
        <p>${post.body}</p>
      </div>
      `
            });
            document.getElementById('output').innerHTML = posts;
        });
}

// post posts to the server
function addPost(e) {
    e.preventDefault();

    let title = document.getElementById('title').value;
    let body = document.getElementById('body').value;

    fetch('https://jsonplaceholder.typicode.com/posts', {
        method: 'POST',
        headers: {
            'Accept': 'application/json, text/plain , */*',
            'content-type': 'application/json'
        },
        body: JSON.stringify({
            title: title,
            body: body
        })
    })
        .then((response) => response.json())
        .then((data) => {
            if (data.title == '' && data.body == '') {
                alert('please enter your title and content');
            } else {
                post = '<h4 class="mb-4">Your new post</h4>'
                post += `
        <div class="card card-body mb-3">
          <h5>post title : ${data.title}</h5>
          <p>post content : ${data.body}</p>
        </div>
        `
                document.getElementById('output').innerHTML = post;
            }
        });
}