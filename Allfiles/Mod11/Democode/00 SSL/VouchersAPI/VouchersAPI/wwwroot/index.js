window.addEventListener('load', function() {
	let url = `${window.location.href}api/vouchers`;
	fetch(url)
		.then((resp) => {
			console.log('Response received from fetch', resp);
			return resp.json();
		})
		.then((data) => {
			console.log('Data received from fetch', data);
			document.querySelector('#result').innerHTML = JSON.stringify(data);
		});
});
