#include <stdio.h>
#include <stdlib.h>

// 全局变量，用于存储异或操作的临时结果
unsigned char tmp = 0x90; // tmp的初始值是0x90
int check = 0; // 用于验证是否所有节点都已访问

// 定义二叉树节点结构
typedef struct TreeNode {
    unsigned char value;
    struct TreeNode *left;
    struct TreeNode *right;
} TreeNode;

// 创建二叉树节点
TreeNode* createNode(unsigned char value) {
    TreeNode* node = (TreeNode*)malloc(sizeof(TreeNode));
    node->value = value;
    node->left = NULL;
    node->right = NULL;
    return node;
}

// 后序遍历并进行异或操作
void postorderTraversal(TreeNode* root) {
    if (root == NULL) return;
    postorderTraversal(root->left);
    postorderTraversal(root->right);
    // 进行异或操作
    root->value ^= tmp;
    tmp = root->value; // 更新tmp
}

// 根据层序遍历的数组创建完全二叉树
TreeNode* createTreeByLevelOrder(unsigned char* values, int size) {
    if (size == 0) return NULL;
    TreeNode** nodes = (TreeNode**)malloc(size * sizeof(TreeNode*));
    for (int i = 0; i < size; ++i) {
        nodes[i] = createNode(values[i]);
    }
    for (int i = 0; i < size; ++i) {
        if (2 * i + 1 < size) nodes[i]->left = nodes[2 * i + 1];
        if (2 * i + 2 < size) nodes[i]->right = nodes[2 * i + 2];
    }
    TreeNode* root = nodes[0];
    free(nodes);
    return root;
}

// 主函数
int main() {
    unsigned char values[32];
    // 读取32个字符
    for (int i = 0; i < 32; ++i) {
        printf("输入\n");
        scanf("%c", &values[i]);
    }
    // 创建二叉树
    TreeNode* root = createTreeByLevelOrder(values, 32);
    // 后序遍历并进行异或操作
    postorderTraversal(root);
    // 输出结果
    for (int i = 0; i < 32; ++i) {
        printf("%c", values[i]);
    }
    printf("\n");
    return 0;
}
