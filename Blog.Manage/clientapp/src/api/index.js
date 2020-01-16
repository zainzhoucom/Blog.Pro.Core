import axios from 'axios';

const defaultHeaders = {

}

//请求拦截器
axios.interceptors.request.use(config => {
    //请求发出之前
    console.log(config);
    if(config.url !== '/users/login'){
        const user = sessionStorage.getItem('user');
        if(user){
            const userJson = JSON.parse(user);
            config.headers = {
                'authToken': userJson.token
            }
        }
    }
    return config;
},error => {
    //请求错误
    return Promise.reject(error);
});
//响应拦截
axios.interceptors.response.use(response => {
    console.log(response);
    const {code, msg, data} = response.data;
    if(code === '0000'){
        const config = response.config;
        if(config.url === '/users/login'){
            sessionStorage.setItem('user',JSON.stringify(data));
        }
        return response;
    }else{
        return Promise.reject(msg);
    }
},error => {
    //响应错误
    console.log(error);
    return Promise.reject(error);
});