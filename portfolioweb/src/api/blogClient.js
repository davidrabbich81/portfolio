import axios from 'axios'

export default {
    getBlogs: () =>
        axios({
            'method':'GET',
            'url':'https://localhost:7214/api/Blog',
            'headers': {
                'content-type':'application/json',
            }
        }),
    getBlog: (id) =>
        axios({
            'method':'GET',
            'url':`https://localhost:7214/api/Blog/${id}`,
            'headers': {
                'content-type':'application/json'
            }
        }),
}